using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace ViewComponetDemo
{
    public class MenuViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int selectedMenuIndex, bool isBold)
        {
            List<Menu> menus = new List<Menu>
            {
                new Menu() { Text = "Home",URL = "/",isSelected = selectedMenuIndex==0, isBold = isBold}, 
                new Menu() { Text = "Services",URL = "/services",isSelected = selectedMenuIndex==1, isBold = isBold},
                new Menu() { Text = "AboutUs",URL = "/home/aboutus",isSelected = selectedMenuIndex==2, isBold = isBold},
                new Menu() { Text = "ContactUs",URL = "/contactus",isSelected = selectedMenuIndex==3, isBold = isBold},
             };

            return View(menus);
        }
    }
    public class Menu
    {
        public string Text;
        public string URL;
        public bool isSelected;
        public bool isBold;
    }
}
