using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace webapp.Controllers
{
    public class HelloController : Controller
    {
        // 
        // GET: /Hello/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /Hello/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}