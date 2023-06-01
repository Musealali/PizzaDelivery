using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaDeliveryRazorPages.Models;

namespace PizzaDeliveryRazorPages.Pages.Forms;

public class CustomPizza : PageModel
{
    [BindProperty]
    public PizzasModel Pizza { get; set; }
    public void OnGet()
    {
        
    }
}