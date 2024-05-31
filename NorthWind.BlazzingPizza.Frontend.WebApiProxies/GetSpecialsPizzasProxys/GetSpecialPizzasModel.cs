using NorthWind.BlazzingPizza.Frontend.BussinessObjects.Interfaces.GetSpecialPizzasInterfaces;

namespace NorthWind.BlazzingPizza.Frontend.WebApiProxies.GetSpecialsPizzasProxys;

internal class GetSpecialPizzasModel : IGetSpecialsPizzasModel
{
    IEnumerable<PizzaSpecialDto> SpecialPizzas =
    [
        new(1,
            "Pizza clásica de queso",
            89.99m,
            "Es de queso y delicioso. ¿Por qué no querrás una?",
            "cheese.jpg"),
        new(2,
            "Tocinator",
            127.99m,
            "Tiene TODO tipo de tocino",
            "bacon.jpg"),
        new(3,
            "Clásica de pepperoni",
            99.50m,
            "Es la pizza con la que creciste, ¡pero ardientemente deliciosa!",
            "pepperoni.jpg"),
        new(4,
            "Pollo búfalo",
            128.75m,
            "Pollo picante, salsa picante y queso azul, garantizado que entrarás en calor",
            "meaty.jpg"),
        new(5,
            "Amantes del champiñon",
            109.00m,
            "Tiene champiñones. ¿No es obvio?",
            "mushroom.jpg"),
        new(6,
            "Hawaiana",
            90.25m,
            "De piña, jamón y queso...",
            "hawaiian.jpg"),
        new(7,
            "Delicia vegetariana",
            118.50m,
            "Es como una ensalada, pero en una pizza",
            "salad.jpg"),
        new(8,
            "Margarita",
            89.99m,
            "Pizza italiana tradicional con tomates y albahaca",
            "margherita.jpg")
    ];
    public async Task<IEnumerable<PizzaSpecialDto>> GetSpecialsPizzasAsync() => await Task.FromResult(SpecialPizzas.OrderByDescending(p => p.BaseCost));

}