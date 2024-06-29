using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using versta_test.Data;
using versta_test.Models;

namespace versta_test.Controllers;

public class OrdersController : Controller
{
    private readonly OrderContext _context;

    public OrdersController(OrderContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var orders = _context.Orders.ToList();
        return View(orders);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create([Bind("SenderCity,SenderAddress,ReceiverCity,ReceiverAddress,Weight,PickupDate")] Order order)
    {
        if (ModelState.IsValid)
        {
            _context.Add(order);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        return View();
    }

    public IActionResult Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var order = _context.Orders
            .FirstOrDefault(m => m.Id == id);
        if (order == null)
        {
            return NotFound();
        }

        return View(order);
    }
}