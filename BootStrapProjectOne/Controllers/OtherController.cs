using BootStrapProjectOne.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;


namespace BootStrapProjectOne.Controllers
{
    
    
    public class OtherController : Controller
    {
        public static List<Question> lstQuestions = new List<Question>()
        {
            new Question{ sQuestion = "What interested you in the first place about the company you interned for?" },
            new Question{ sQuestion = "What was the hardest part about trying to decide which company to intern at?" },
            new Question{ sQuestion = "What if I get an internship with a company and then decide that I don't like it?" }
        };
        
        public ActionResult FullWidth()
        {
            return View();
        }
        
        public ActionResult SideBar()
        {
            return View();
        }
        
        public ActionResult Faq()
        {
            return View(lstQuestions);
        }

        [HttpGet]
        public ActionResult CreateFaq()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateFaq(Question oQuestion)
        {
            oQuestion.Question_ID = lstQuestions.Count + 1;

            if (ModelState.IsValid)
            {
                lstQuestions.Add(oQuestion);
                return View("FAQ", lstQuestions);
            }
            else //If validation fails, we will essentially reload the AddQuestion page, with the errors thrown and displayed
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
                return View(oQuestion);
            }
        }
    }
}
