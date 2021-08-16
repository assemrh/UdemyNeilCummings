using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetProducts()
        {
            return Content("this is my first api");
        }
        [HttpGet("{id}")]
        public ActionResult<int> GetProduct( int id)
        {

            return 0;
        }

        public void MyTestMethod()
        {

        }
        


    }
}
