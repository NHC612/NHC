using Microsoft.AspNetCore.Mvc;
using Baithuchanh2003.Models;
using Baithuchanh2003.Models.Process;
namespace Baithuchanh2003.Controllers;

    public class PersonController: Controller
    {
    public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee std)
        {
            string trave = std.EmployeeCode + "-" + std.EmployeeName + "- " + std.Address;
            ViewBag.m = trave;
            return View();
        }
    }

