using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.DataAccess;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Entities;

namespace WebStore.Controllers
{
    [Route("html/[controller]")]
    public class HtmlClientContoller : Controller
    {
        private IClientRepository _clientRepository { get; set; }
        public HtmlClientContoller(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        [HttpGet]
        public IActionResult Index(string lastName)
        {
            return View(_clientRepository.GetClientByLastName(lastName));
        }
        [HttpGet("{id}")]
        public ActionResult Details(int id)
        {
            return View(_clientRepository.Get(id));
        }

        [HttpGet("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Client client)
        {
            try
            {
                _clientRepository.Add(client);

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
            return View(_clientRepository.Get(id));
        }

        [HttpPost("update/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [FromForm] Client client)
        {
            try
            {
                _clientRepository.Update(client);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
}
