using ContactApp.Models;
using ContactApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContactApp.Controllers
{
    [Route("Contact")]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        [Route("/")]
        [Route("ShowContacts")]

        public IActionResult ShowContacts()
        {
            var contacts = _contactService.GetAllContacts();
            return View(contacts);
        }
        [HttpGet]
        [Route("GetContactById/{id}")]

        public IActionResult GetContactById(int id)
        {
            var contact = _contactService.GetContactById(id);
            return View(contact);
        }
        public IActionResult SearchContact()
        {
            return View();
        }

        [HttpGet]
        [Route("AddContact")]

        public IActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        [Route("AddContact")]

        public IActionResult AddContact(ContactInfo contact)
        {
            _contactService.AddContact(contact);
            return RedirectToAction("ShowContacts");
        }
    }
}
