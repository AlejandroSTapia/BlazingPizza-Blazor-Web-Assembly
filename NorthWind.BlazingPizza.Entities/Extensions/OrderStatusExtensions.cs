using NorthWind.BlazingPizza.Entities.Enums;
using NorthWind.BlazingPizza.Entities.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Entities.Extensions
{
    public static class OrderStatusExtensions
    {
        public static string ToFriendlyString(this OrderStatus status) =>
            status switch
            {
                OrderStatus.Preparing => Messages.PreparingText,
                OrderStatus.OutForDelivery => Messages.OutForDeliveryText,
                OrderStatus.Delivered => Messages.DeliveredText,
                _ => Messages.UnknownStatusText
            };
    }
}
