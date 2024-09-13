using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.ValidationService.FluentValidation
{
    //tiene los metodos para agregar las reglas pero es abstracta, porlo qu eno se puede instanciar y se requiere heredarla

    //Instanciar de manera indirecta AbstractValidator por medio de otra clase que hereda de AbstractValidator y asi, se instancia esta nueva clase
    internal class AbstractValidationImplementation<T> :AbstractValidator<T>
    {
    }
}

//El validador se creo en la capa 1 en las abastracciones
//se impleento en la capa 1, en los validadores
//Y se uso en la capa 2 en los usecase, en pplaceOrderIteractor donde se invoca e hub de validares donde vineen todos 
//los validadores y regresar a la creacion de la orden, o caso contrario un error
