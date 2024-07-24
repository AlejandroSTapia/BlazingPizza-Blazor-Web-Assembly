using DotNet.Validation.Entities.Enums;
using DotNet.Validation.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Validation.Entities.Interfaces
{
    public interface IModelValidator<T>
    {
        Task<bool> Validate(T model);
        IEnumerable<ValidationError> Errors { get; }

        ValidationConstraint Constraint { get; }
    }
}
