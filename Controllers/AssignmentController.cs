using Microsoft.AspNetCore.Mvc;
using MVCAssignment_1___2.Models;//Should be added in case it is not appier automatically

namespace MVCAssignment_1___2.Controllers
{
    public class AssignmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Greet()
        {
            ViewBag.message = "Welcome to my MVC Assignment!";
            return View();
        }

        [HttpGet] //Every action is type of GET per default. Only one action is [HttpGet] the rest is [HttpPost]
        public IActionResult FeverCheck()//Reciving data. Concept called Action Overloading 
        {     
            Fever obj = new Fever();
            return View(obj);
        }

        [HttpPost]
        public IActionResult FeverCheck(Fever obj)//Object of the Fever is our model. 
        {

            double tempInCelsius = obj.Unit == "Fahrenheit"
            ? (obj.BTemp - 32) * 5 / 9
        :   obj.BTemp;

            if (obj.BTemp > 36.6 && obj.BTemp < 39.4)
                obj.Resultat = "You have a fever.";
            else if (obj.BTemp < 36.6)
                obj.Resultat = "You have symptoms of Hypotherma, please contact 1177";
            else if (obj.BTemp > 39.4)
                obj.Resultat = "You have high fever, immidiatly contact 1177 for more instructions";
            else 
                obj.Resultat = "You do not have a fever";
                return View(obj);


        }



        //public IActionResult GuessingGame()
        //{
            
        //    return View();
        //}



        [HttpGet]//By default
        public IActionResult FindMax()
        {
            GetMax obj = new GetMax();
            return View(obj);
        }

        [HttpPost]
        public IActionResult FindMax(GetMax obj)
        {
            if(obj.Num1 > obj.Num2)
                obj.Message = $"First number: {obj.Num1} is greater then second number: {obj.Num2}";
            
            else if(obj.Num1 < obj.Num2)
                obj.Message = $"First number: {obj.Num1} is smaller then second number: {obj.Num2}";
            
            else
                obj.Message = $"First number: {obj.Num1} is equal with second number: {obj.Num2}";
            
            return View(obj);
        }

        [HttpGet]
        public IActionResult FindMin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FindMin()
        {
            return View();
        }


    }
}
