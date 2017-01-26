using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Persona.Api.Models;
using Persona.Api.Infrastructure;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Persona.Api.Controllers
{
    [Route("api/[controller]")]
    public class PeopleController : Controller
    {
        private GithubPeopleSource GithubPeopleSource => new GithubPeopleSource();

        public List<Person> People => new List<Person>()
        {
            new Person { Id = Guid.NewGuid().ToString(), FirstName="William", LastName="Rodriguez", EmailAddress="ping@williamsrz.com.br", GitHubHandle="williamsrz", TwitterHandle="williamsrodz" }
        };
        
        // GET: api/values
        [HttpGet("{term}")]
        public async Task<IEnumerable<Person>> Get(string term)
        {
            return await GithubPeopleSource.SearchPeopleOnGitHub(term);
        }
    }
}
