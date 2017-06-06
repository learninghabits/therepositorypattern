using System.Web.Http;

namespace repo_pattern.Controllers
{
    public class RootController : ApiController
    {
        // GET api/values
        public string Get()
        {
            return "API is ready to receive requests";
        }        
    }
}