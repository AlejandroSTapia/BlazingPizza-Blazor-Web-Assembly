using NorthWind.BlazingPizza.Entities.Enums;
using NorthWind.BlazingPizza.Entities.Resources;

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
