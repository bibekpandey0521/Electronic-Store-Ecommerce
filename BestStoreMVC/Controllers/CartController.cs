using BestStoreMVC.Models;
using BestStoreMVC.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BestStoreMVC.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly decimal shippingFee;

        public CartController(ApplicationDbContext context, IConfiguration configuration,
            UserManager<ApplicationUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
            shippingFee = configuration.GetValue<decimal>("CartSettings:ShippingFee");
        }
        public IActionResult Index()
        {
            List<OrderItem> cartItems = CartHelper.GetCartItems(Request,Response,context);
            decimal subTotal = CartHelper.GetSubTotal(cartItems);

            ViewBag.CartItems = cartItems;
            ViewBag.ShippingFee = shippingFee;
            ViewBag.SubTotal = subTotal;
            ViewBag.Total = subTotal + shippingFee;

            return View();
        }
    }
}
