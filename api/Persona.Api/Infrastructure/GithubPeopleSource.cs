using Octokit;
using Persona.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persona.Api.Infrastructure
{
    public class GithubPeopleSource
    {
        private readonly IAmOnGithub[] _people;

        public async Task<List<Person>> SearchPeopleOnGitHub(string term)
        {
            var people = new List<Person>();

            var github = new GitHubClient(new ProductHeaderValue("Persona"));
            var searchRequest = new SearchUsersRequest(term);
            var searchResponse = await github.Search.SearchUsers(searchRequest);

            foreach (var item in searchResponse.Items)
            {
                var person = new Person
                {
                    FirstName = item.Name,
                    EmailAddress = item.Email,
                    GitHubHandle = item.Login
                };

                people.Add(person);
            }

            return people;
        }
    }
}

