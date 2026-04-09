using Microsoft.AspNetCore.Mvc;

namespace FeedbackApp.Controllers
{
    [Route("feedback")]
    public class FeedbackController : Controller
    {
        [Route("/")]
        [HttpGet("submit")]
        public IActionResult Submit()
        {
            return View();
        }

        [HttpPost("submit")]
        public IActionResult Submit(string name, string comments, int rating)
        {
            string message;

            if (rating >= 4)
            {
                message = "Thank You for your valuable feedback!";
            }
            else
            {
                message = "We will improve based on your feedback.";
            }

            ViewData["Message"] = message;
            ViewData["UserName"] = name;

            return View();
        }
    }
}
