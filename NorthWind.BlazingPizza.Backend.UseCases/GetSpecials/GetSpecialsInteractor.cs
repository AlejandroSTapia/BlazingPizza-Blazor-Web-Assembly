using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetSpecials;

namespace NorthWind.BlazingPizza.Backend.UseCases.GetSpecials
{
    internal class GetSpecialsInteractor(IGetSpecialsRepository repository,
        IGetSpecialsOutputPort presenter) : IGetSpecialsInputPort
    {
        public async Task GetSpecialsAsync()
        {
            var Special = await repository.GetSpecialsSortedByDescendingPriceAsync();
            await presenter.HandleResultAsync(Special);
        }
    }
}
