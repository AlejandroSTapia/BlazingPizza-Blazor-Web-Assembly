using DotNet.Validation.Entities.Enums;
using DotNet.Validation.Entities.Interfaces;
using DotNet.Validation.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Validation.Entities.Abstractions
{
    public abstract class AbstractViewModelValidator<DtoType, ViewModelType>(
        IModelValidatorHub<DtoType> dtoModelValidatorHub,
        ValidationConstraint constraint): IModelValidator<ViewModelType>
    {
        public ValidationConstraint Constraint => constraint;
        //se encpasula lo que haga el dto, y es lo que se devuelve, no requiere mas logica
        public IEnumerable<ValidationError> Errors =>
            dtoModelValidatorHub.Errors;

        //el viewmodel debe ser capaz de convertirse en un dto 
        //esto se hace porque se validara el dto
        //crear un metodo   que sea virtual que devolvera un tipo dto, hara una oconversion
        // Recibira el viewModel y devolvera un Dto, es virtual para que quien herede pueda sobreescribir
        public virtual DtoType Cast(ViewModelType viewModel)
        {
            //reflection 

            //implementacion predeterminada pero quien herede  de AbstractViewModelValidator que pueda sobreescriirse
            //y si hereda ya no hara este codigo, si no sobreescribe si lo hara
            DtoType DtoModel = default;
            //preguntar si el viewmodel implmeneta el operador casts, si lo implementa, lo invoca, si no
            //, no se puede hacer la conversion y error
            //buscara ese method
            var ExplicitMethod = typeof(ViewModelType).GetMethod("op_Explicit");
            if (ExplicitMethod != null)
            
                DtoModel = (DtoType)ExplicitMethod.Invoke(viewModel, new object[] {viewModel});
            
            else
            
                throw new InvalidOperationException();
                return DtoModel;
            
        }

        //metodo para que diga si se cumple la validacion si o no
        public Task<bool> Validate(ViewModelType model) =>
            dtoModelValidatorHub.Validate(Cast(model));
    }
}


//Esa es la idea. Entonces, el Código Backend puede validar los datos de entrada implementando 
//    validación en los objetos DTOY. Por otro lado, los datos de entrada que una aplicación 
//    front end solicita al usuario pueden almacenarse en un view model, que también necesitará ser validado. 
//    Entonces, este código nos va a permitir del que el Código Front end utilice la validación definida para el DTO correcto. 