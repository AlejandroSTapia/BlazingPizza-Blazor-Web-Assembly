using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Validation.Entities.ValueObjects
{
    //ayuda a guardar mensajes de error
    public class ValidationError(string propertyName, string message)
    {
        public string PropertyName => propertyName;
        //public string Message { get; set; }
        public string Message => message;
    }
}
