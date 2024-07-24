using DotNet.Validation.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Validation.Entities.Interfaces
{
    internal interface IValidationService<T>
    {
        IValidationRules<T, TProperty> AddRuleFor<TProperty>(
            Expression<Func<T, TProperty>> expression);

        ICollectionValidationRules<T, TProperty> AddRuleForEach<TProperty>(
            Expression<Func<T, IEnumerable<TProperty>>> expression);

        Task<IEnumerable<ValidationError>> Validate(T model);
    }
}
