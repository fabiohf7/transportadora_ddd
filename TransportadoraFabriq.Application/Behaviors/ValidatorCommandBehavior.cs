﻿using FluentValidation;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TransportadoraFabriq.Shared.Notification;

namespace TransportadoraFabriq.Application.Behaviors
{
    public class ValidatorCommandBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly IValidator<TRequest>[] _validators;
        private readonly ILogger<ValidatorCommandBehavior<TRequest, TResponse>> _logger;
        private readonly IMediator _mediator;

        public ValidatorCommandBehavior(IValidator<TRequest>[] validators, ILogger<ValidatorCommandBehavior<TRequest, TResponse>> logger,
            IMediator mediator)
        {
            _validators = validators;
            _logger = logger;
            _mediator = mediator;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            var failures = _validators
                .Select(v => v.Validate(request))
                .SelectMany(result => result.Errors)
                .Where(error => error != null)
                .ToList();

            if (failures.Any())
            {
                _logger.LogTrace($"Command Validation Errors for type {typeof(TRequest).Name}");

                foreach (var item in failures)
                {
                    await _mediator.Publish(new NotificationDomain(item.PropertyName, item.ErrorMessage));
                }

                return default(TResponse);
            }

            var response = await next();
            return response;
        }
    }
}
