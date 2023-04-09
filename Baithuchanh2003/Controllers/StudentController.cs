using Microsoft.AspNetCore.Mvc;
using BaiThucHanh0703.Models;
using BaiThucHanh0703.Models.Process;

namespace BaiThucHanh0703.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student std)
        {
            string trave = std.StudentCode + "-" + std.StudentName + "- " + std.Address;
            ViewBag.m = trave;
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
         public IActionResult Index(string FullName, string PhoneNumber)
        {
            string strReturn = "Hello " + FullName + "-" +PhoneNumber;
            //gui du lieu ve view
            ViewBag.thongbao = strReturn;
            return View();
            //tra ve danh sach cac sinh vien trong Database
        }