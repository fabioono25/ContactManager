using ContactManager.Dtos;
using ContactManager.Models;
using ContactManager.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;

namespace ContactManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContactService _contactService;

        public HomeController(IContactService contactService)
        {
            _contactService = contactService;
        }
        /// <summary>
        /// I`m returning the list of contacts, but I didn`t have time to iterate in UI
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var contacts = _contactService.GetContacts();

            var contact = new ContactDto
            {
                Id = 3,
                Name = "Supplier2",
                Phone = "234234",
                BirthDate = DateTime.Now
            };

            _contactService.AddContact(contact);

            contacts = _contactService.GetContacts();

            return View(contacts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
