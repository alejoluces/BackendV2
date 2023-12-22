using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        [HttpGet("all")]
        public List<People> GetPeoples()
        {
            return Repository.People;

        }

        [HttpGet("{id}")]
        public ActionResult<People> Get(int id)
        {
            var people = Repository.People.FirstOrDefault(item => item.Id == id);

            if (people == null)
                return NotFound();
            return Ok(people);

        }

        [HttpGet("search/{search}")]
        public List<People> Get(string search)
        {
            return Repository.People.Where(item => item.Name.ToUpper().Contains(search.ToUpper())).ToList();
        }


        [HttpPost]
        public IActionResult Post(People people)
        {
            if (string.IsNullOrEmpty(people.Name))
            {
                return BadRequest();
            }
            {
                Repository.People.Add(people);
                return NoContent();
            }


        }

        public class Repository
        {
            public static List<People> People = new List<People>
        {
            new People(){
                Id = 1, Name = "Pedro", Birthdate = new DateTime(1992,11,3)
             },
            new People(){
                Id = 2, Name = "Juan", Birthdate = new DateTime(1986,12,23)
             },
            new People(){
                Id = 3, Name = "Alejo", Birthdate = new DateTime(1990,12,3)
             }

        };
        }

        public class People
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public DateTime Birthdate { get; set; }


        }
    }
}
