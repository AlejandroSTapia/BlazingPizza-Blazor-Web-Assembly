using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Entities.Dtos.Common
{
    public class AddressDto(string name, string addressLine1,
        string addressLine2, string city, string region, string postalCode)
    {
        public string Name => name;
        public string AddressLine1 => addressLine1;
        public string AddressLine2 => addressLine2;
        public string City => city;
        public string Region => region;
        public string PostalCode => postalCode;
    }
}
