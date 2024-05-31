using Microsoft.AspNetCore.Components;
using NortWind.BlazzingPizza.Frontend.ViewModels.GetSpecialsPizzasViewModel;

namespace NorthWind.BlazzingPizza.Frontend.RazorViews.Components;
public partial class SpecialPizza
{
    [Inject]
    public GetSpecialsPizzasViewModel ViewModel { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await ViewModel.GetSpecialsPizzasAsync();
    }
}