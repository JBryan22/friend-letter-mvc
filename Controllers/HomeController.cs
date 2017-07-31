using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Hello()
        {
          LetterVariables myLetterVariable = new LetterVariables();
          myLetterVariable.SetSender("Charlie");
          myLetterVariable.SetRecipient("Eric");
          return View(myLetterVariable);
        }

        [Route("/favorite_photos")]
        public ActionResult FavoritePhotos()
        {
            LetterVariables myLetterVariable = new LetterVariables();
            myLetterVariable.SetLocation("Hawaii");
            return View(myLetterVariable);
        }

        [Route("/goodbye")]
        public string Goodbye()
        {
            return "Goodbye friend.";
        }

        [Route("/form")]
        public ActionResult Form()
        {
            return View();
        }

        [Route("/greeting_card")]
        public ActionResult GreetingCard()
        {
        
            LetterVariables myLetterVariable = new LetterVariables();
            myLetterVariable.SetRecipient(Request.Query["recipient"]);
            myLetterVariable.SetSender(Request.Query["sender"]);
            myLetterVariable.SetLocation(Request.Query["location"]);
            return View("Hello", myLetterVariable);
        }
    }
}
