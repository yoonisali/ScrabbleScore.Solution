using Microsoft.AspNetCore.Mvc;
using ScrableScore.Models;

namespace ScrableScore.Controllers
{
  public class HomeController : Controller 
  {
    [Route("/")]
    public ActionResult Home() { return View(); }

    [Route("/result")]
    public ActionResult Result(string input)
    {
      Score score = new Score();
      score.ValueScore(score.SplitWord(input));
      return View(score);
    }
  }
}