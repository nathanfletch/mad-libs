using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Welcome() { 
      return View();
    }

    /*
    Controller:
      add routes:
       /, /form, /postcard
      Ours: / - welcome to madlibs select from 2 stories - buttons?(could be form with one button) /form (2 pages?), /display (2?)

      find a story - 5-10 inputs - 

    Views:
      write the form.cshtml (on landing page?)

    Model:
      class definition: MadVariables?

    
    */
  }  
}