using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;
using FirstCoreWebApp.Models;


namespace FirstCoreWebApp.Controllers

{
    public class ProductController : Controller
    {

        public static List<Product> list = new List<Product>
        {
            new Product(){ Pid=1,Pname="Books", Price=200,Stock=50},
            new Product() { Pid=2,Pname="pens", Price=10, Stock=1000},
            new Product() { Pid=3,Pname="Calculator", Price=1000, Stock=100},
            new Product() { Pid=4,Pname="Pencil", Price=2, Stock=150}
        };

        public IActionResult Index()
        {
            return View(list);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                list.Add(product);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create");
            }

        }
    }
}
