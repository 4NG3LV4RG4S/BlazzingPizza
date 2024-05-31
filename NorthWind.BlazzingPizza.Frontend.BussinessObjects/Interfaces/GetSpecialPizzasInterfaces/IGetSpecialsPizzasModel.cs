namespace NorthWind.BlazzingPizza.Frontend.BussinessObjects.Interfaces.GetSpecialPizzasInterfaces;

public interface IGetSpecialsPizzasModel
{
    Task<IEnumerable<PizzaSpecialDto>> GetSpecialsPizzasAsync();
}