using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{

  public class HomeController : Controller
  {
    public static Story MyStory { get; set; }

    [Route("/")]
    public ActionResult Welcome() { 
      return View();
    }

    [Route("/form")]
    public ActionResult Form(string storyNumber) {
      MyStory = new Story(); 
      MyStory.StoryNumber = storyNumber;
      //model binding: inside Form.cshtml, @Model = myStory (but only inside Form.cshtml)
      return View(MyStory);
    }

    [Route("/display")]
    public ActionResult Display(string adjective, string food1, string verb, string saying, string noun, string food2, string color, string ride, string animal, string person)
    {
       
      //make var
      MadVariables myVariables = new MadVariables();
      //set the properties
      myVariables.Adjective = adjective;
      myVariables.Food1 = food1;
      myVariables.Verb = verb;
      myVariables.Saying = saying;
      myVariables.Noun = noun;
      myVariables.Food2 = food2;
      myVariables.Color = color;
      myVariables.Ride = ride;
      myVariables.Animal = animal;
      myVariables.Person = person;
      myVariables.StoryNumber = MyStory.StoryNumber;

      // pass 2 models
      // reassign the storynumber to a new property on MadVariables

      //pass them to view
      return View(myVariables);
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