using Microsoft.AspNetCore.Mvc;
using Quote_Generator.Models;

namespace Quote_Generator.Controllers
{

    public class QuoteController : Controller
    {
        // List of quotes (replace with actual data or data access logic)
        private static List<Quote> quotes = new List<Quote>()
  {
    new Quote { Text = "The best and most beautiful things in the world cannot be seen or even touched - they must be felt with the heart.", Author = "Helen Keller" },
    new Quote { Text  = "The only person you are destined to become is the person you decide to be.", Author = "Ralph Waldo Emerson"  },
    new Quote { Text = "To be yourself in a world that is constantly trying to make you something else is the greatest accomplishment.", Author = "Ralph Waldo Emerson"},
    new Quote { Text = "It is never too late to be what you might have been.", Author = "George Eliot"},
    new Quote { Text = "That it will never come again is what makes life so sweet.", Author = "Emily Dickinson"},
    new Quote { Text = "To live is the rares thing in the world. Most people exist, that is all.", Author = "Oscar Wilde"},
    new Quote { Text = "Amateurs sit and wait for inspiration, the rest of us just get up and go to work.", Author = "Stephen King"},
    new Quote { Text = "Self-awareness and self-love matter. Who we are is how we lead.", Author = "Brene Brown"},




  };


        public IActionResult Quote()
        {
            // Generate random index within the quotes list
            var randomIndex = new Random().Next(quotes.Count);
            var randomQuote = quotes[randomIndex];

            // Pass the random quote to the view
            return View("Quote", randomQuote);
        }
    }
}
