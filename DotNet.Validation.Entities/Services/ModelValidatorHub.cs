using DotNet.Validation.Entities.Enums;
using DotNet.Validation.Entities.Interfaces;
using DotNet.Validation.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Validation.Entities.Services
{
    //Este va a ainvocar a los validates d elos modelvalidator
    internal class ModelValidatorHub<ModelType>(
        IEnumerable<IModelValidator<ModelType>> validators):
        IModelValidatorHub<ModelType>
    {
        public IEnumerable<ValidationError> Errors {  get; private set; }
        public async Task<bool> Validate(ModelType model)
        {
            List<ValidationError> CurrentErrors = []; //esto permitira ir recopilando los errores de cada validador
            var Validators = validators
                .Where(v => v.Constraint == ValidationConstraint.AlwaysValidate)//primero se valida contra los validadores que siempre deben evaluarse
                .ToList();

            //rango de los validadores que recibi
            Validators.AddRange(validators
                .Where(v => v.Constraint == ValidationConstraint.ValidateIfThereAreNoPreviousErrors)); 

            //ya que se tienen todos los validadores, ya se pueden recorrer
            foreach (var Validator in Validators)
            {
                //si siempre te tienes que validar, entonces te valido
                if((Validator.Constraint == ValidationConstraint.AlwaysValidate) ||
                    CurrentErrors.Any())
                {
                    //si no fuiste capaz de validar tu modelo, entonces dame tus errores
                    if(!await Validator.Validate(model))
                    {
                        CurrentErrors.AddRange(Validator.Errors);
                    }
                }
            }

            //se deben guardar todos los errores que se hayan encontrado
            Errors = CurrentErrors;
            //si no hubo errores, devuelve true
            return !Errors.Any();
        }
    }
}
