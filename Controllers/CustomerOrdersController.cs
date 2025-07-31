using CustomerOrderApp.Models;
using CustomerOrderApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CustomerOrderApp.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Derya",
                LastName = "Karahan",
                Email = "derya@example.com"
            };

            var orders = new List<Order>
            {
                new Order { Id = 101, ProductName = "Laptop", Price = 15000, Quantity = 1 },
                new Order { Id = 102, ProductName = "Mouse", Price = 250, Quantity = 2 },
                new Order { Id = 103, ProductName = "Klavye", Price = 450, Quantity = 1 }
            };

            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            return View(viewModel);
        }
    }
}