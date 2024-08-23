using DotNet.Validation.Entities.Enums;
using DotNet.Validation.Entities.Interfaces;
using DotNet.Validation.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Validation.Entities.Abstractions
{
    //Abstractions son para no hacer el proceso repetitivo de implementacion:
    //Pedir validation servie,
    //    gregar las reglas,
    //    agrega el metodo Validate
    //Entonces sse va a encapsular en una clase el codigo que se repite
    //para que los validadores solo hereden esa clase base sin ya repetir codigo

    //Todos los validadores deben tener esto

    //Aqui ira el codigo base de los validadores
    //sera abstract porque no podra ser utilizada, solo podra ser implementado
    //que se requiere paa poder validar? pues un IValidationService que es el que realmente hace todoo el trabajo
    public abstract class AbstractModelValidator<T>(
        IValidationService<T> validationService,
        //si el validador se validara siempre pero la mayor parte de las veces es para validar tosdo, a solo que se diga lo contrario asi serra
        ValidationConstraint constraint = ValidationConstraint.AlwaysValidate)
        : IModelValidator<T>
    {
        public ValidationConstraint Constraint => constraint;
        public IEnumerable<ValidationError> Errors {  get; set; }
        //Tambien todos los validadores deben de implementar un metodo que develva bool que reciba un modelo
        public async Task<bool> Validate(T model)
        {
            Errors = await validationService.Validate(model);
            return Errors == default; //Caundo no haya errores, errors se va a quedar con su valor default
        }

        //
        protected IValidationRules<T, TProperty> AddRuleFor<TProperty>(
            Expression<Func<T,TProperty>> expression) =>
            validationService.AddRuleFor<TProperty>(expression);

        protected ICollectionValidationRules<T, TProperty> AddRuleForEach<TProperty>(
            Expression<Func<T, IEnumerable<TProperty>>> expression) =>
            validationService.AddRuleForEach<TProperty>(expression);

        public IValidationService<T> ValidationService => validationService;
    }
}
