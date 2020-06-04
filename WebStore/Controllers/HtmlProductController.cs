using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Entities;
using Infrastructure.DataAccess;

namespace WebStore.Controllers
{
    [Route("html/[controller]")]
    public class HtmlProductController : Controller
    {
        private IProductRepository _productRepository { get; set; }

        public HtmlProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet("{id}")]
        public ActionResult Details(int id)
        {
            return View(_productRepository.Get(id));
        }

        [HttpGet("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Product product)
        {
            try
            {
                _productRepository.Add(product);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet("update/{id}")]
        public ActionResult Edit(int id)
        {
            return View(_productRepository.Get(id));
        }

        [HttpPost("update/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [FromForm] Product product)
        {
            try
            {
                _productRepository.Update(product);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
