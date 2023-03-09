using AzurePresentationWebDeployment.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AzurePresentationWebDeployment.Controllers;

public class HomeController : Controller
{
    private readonly AzurePresentationDbContext _context;

    public HomeController(AzurePresentationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Customers.ToList());
    }
}