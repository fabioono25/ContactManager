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
        /// It's good to create different methods, to add a customer or a supplier and handle this logic to add a customer or supplier directly in UI
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

            var contactViewModel = new ContactViewModel
            {
                Contacts = _contactService.GetContacts()
            };

            return View(contactViewModel);
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
