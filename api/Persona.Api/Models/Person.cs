using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persona.Api.Models
{
    public class Person : IAmAPerson, IAmOnTwitter, IAmOnGithub
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TwitterHandle { get; set; }
        public string GitHubHandle { get; set; }
        public string EmailAddress { get; set; }
    }

    public interface IAmAPerson
    {
         string Id { get; set; }
         string FirstName { get; set; }
         string LastName { get; set; }
         string EmailAddress { get; set; }
    }
    public interface IAmOnTwitter : IAmAPerson
    {
        string TwitterHandle { get; set; }
    }
    public interface IAmOnGithub : IAmAPerson
    {
        string GitHubHandle { get; set; }
    }

}
