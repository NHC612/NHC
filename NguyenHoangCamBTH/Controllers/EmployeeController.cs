using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NguyenHoangCamBTH.Models;

namespace NguyenHoangCamBTH.Controllers;

    public class EmployeeController : Controller 
    {
        public IActionResult Index()
    {
        return View();
    }
    }