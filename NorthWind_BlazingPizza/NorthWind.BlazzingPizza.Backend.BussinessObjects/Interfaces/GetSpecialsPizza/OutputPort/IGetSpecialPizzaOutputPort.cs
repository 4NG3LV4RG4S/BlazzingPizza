using NortWind.BlazzingPizza.Entities.DTOs.GetSpecialsPizzas;

namespace NorthWind.BlazzingPizza.Backend.BussinessObjects.Interfaces.GetSpecialsPizza.OutputPort;

public interface IGetSpecialPizzaOutputPort
{
    IEnumerable<PizzaSpecialDto> PizzaSpecial { get; }
    Task HandleResultAsync(IEnumerable<PizzaSpecialDto> pizzaSpecialList);
}