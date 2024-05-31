namespace NortWind.BlazzingPizza.Entities.DTOs.GetSpecialsPizzas;

public class PizzaSpecialDto(int id, string name, decimal baseCost, string description, string imageUrl)
{
    public int Id => id;
    public string Name => name;
    public decimal BaseCost => baseCost;
    public string Description => description;
    public string ImageUrl => imageUrl;
    public string BaseCostFormatter => baseCost.ToString("0.00");
}