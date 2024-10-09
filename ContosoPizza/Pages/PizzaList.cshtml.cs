using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContosoPizza.Pages
{
    public class PizzaListModel : PageModel
    {
        private readonly PizzaService _service;
        public IList<Pizza> PizzaList { get; set;}=default!;

        public PizzaListModel(PizzaService pizzaService){
            this._service=pizzaService;
        }

        public void OnGet()
        {
            PizzaList = this._service.GetPizzas();
        }
    }
}
