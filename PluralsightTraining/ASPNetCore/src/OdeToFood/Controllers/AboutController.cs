using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    [Route("company/[controller]/[action]")]
    public class AboutController
    {
        //[Route("[action]")]
        public string Phone()
        {
            return "1+555-555-5555";
        }

        //[Route("[action]")]
        public string Address()
        {
            return "USA";
        }
    }
}
