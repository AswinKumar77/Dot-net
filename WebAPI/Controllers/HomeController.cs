using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase 
    {
     
        private readonly ApplicationDbContext _dbcontext;

        public HomeController(ApplicationDbContext _dbcontext)
        {
           this._dbcontext = _dbcontext;
        }

        [HttpGet]
        public ActionResult<List<PlayerModel>> Get()
        {
            return _dbcontext.PlayerDetails.ToList();
        }

        [HttpPost]
        public ActionResult<PlayerModel> Create([FromBody]PlayerModel model)
        {
            _dbcontext.PlayerDetails.Add(model);
            _dbcontext.SaveChanges();
            return Ok();
        }
    }
}
