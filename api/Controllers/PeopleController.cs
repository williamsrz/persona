using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Persona.Api.Models;

namespace Persona.Api.Controllers
{
    [Route("api/people")]
    public class PeopleController : Controller
    {
        List<Person> _people => new List<Person>();

        [HttpGet]
        public IEnumerable<Person> GetAll()
        {
            return _people.AsReadOnly();
        }
    }
}