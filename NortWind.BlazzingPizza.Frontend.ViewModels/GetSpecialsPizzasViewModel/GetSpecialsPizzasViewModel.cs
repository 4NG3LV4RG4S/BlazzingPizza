namespace NortWind.BlazzingPizza.Frontend.ViewModels.GetSpecialsPizzasViewModel;
public class GetSpecialsPizzasViewModel(IGetSpecialsPizzasModel model)
{
    public IEnumerable<PizzaSpecialDto> SpecialsPizzas { get; private set; }

    public async Task GetSpecialsPizzasAsync()
    {
        SpecialsPizzas = await model.GetSpecialsPizzasAsync();
    }
}