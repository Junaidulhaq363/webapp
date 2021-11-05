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

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}