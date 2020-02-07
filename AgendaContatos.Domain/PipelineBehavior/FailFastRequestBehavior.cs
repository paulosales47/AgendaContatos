using AgendaContatos.Domain.Commands;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AgendaContatos.Domain.PipelineBehavior
{
    public class FailFastRequestBehavior<TRequst, TResponse> : IPipelineBehavior<TRequst, TResponse>
        where TRequst : IRequest<TResponse> where TResponse : Response
    {
        private readonly IEnumerable<IValidator> _validators;

        public FailFastRequestBehavior(IEnumerable<IValidator<TRequst>> validators)
        {
            _validators = validators;
        }

        public Task<TResponse> Handle(TRequst request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            var failures = _validators
                .Select(v => v.Validate(request))
                .SelectMany(result => result.Errors)
                .Where(f => f != null)
                .ToList();

            
            return failures.Any() ? Errors(failures) : next();
        }

        private Task<TResponse> Errors(List<ValidationFailure> failures)
        {
            var response = new Response();

            foreach (var failure in failures)
            {
                
            }

            return Task.FromResult(response as TResponse);
        }
    }
}
