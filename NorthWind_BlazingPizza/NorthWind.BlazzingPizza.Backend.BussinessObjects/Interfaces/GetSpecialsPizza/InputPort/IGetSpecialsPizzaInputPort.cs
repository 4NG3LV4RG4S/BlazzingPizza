using NortWind.BlazzingPizza.Entities.DTOs.GetSpecialsPizzas;

namespace NorthWind.BlazzingPizza.Backend.BussinessObjects.Interfaces.GetSpecialsPizza.InputPort;

public interface IGetSpecialsPizzaInputPort
{
    Task<PizzaSpecialDto> GetSpecialPizza();
}