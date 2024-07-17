using NorthWind.BlazingPizza.Entities.Dtos.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Frontend.ViewModels.Common
{
    public class AddressViewModel
    {
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }

        public static explicit operator AddressDto(AddressViewModel address) => //conversion del viewmodel par el dto
            new AddressDto(
                address.Name,
                address.AddressLine1,
                address.AddressLine2,
                address.City,
                address.Region,
                address.PostalCode);
    }
}
