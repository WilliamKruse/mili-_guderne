using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Collections;
using festivalprojekt.Server.Models;
using festivalprojekt.Shared.Models;



namespace festivalprojekt.Server.Controllers
{
    [ApiController]
    [Route("api/festivalapi/personer")]

    public class PersonController : ControllerBase
    {
        private readonly IPersonRepositoryDapper repo;

        public PersonController(IPersonRepositoryDapper personRepositoryDapper)
        {
            if (personRepositoryDapper != null)
            {
                repo = personRepositoryDapper;
                Console.WriteLine("Repository Initialized");
            }
        }

        [HttpGet("hentallekompetencer")]
        public async Task<IEnumerable<Kompetencer>> HentAlleKompetencer()
        {
            return await repo.HentAlleKompetencer();
        }
        [HttpGet("hentallepersoner")]
        public async Task<IEnumerable<PersonDTO>> HentAllePersoner()
        {
            return await repo.HentAllePersoner();
        }
        [HttpGet("hentperson")]
        public async Task<IEnumerable<PersonDTO>> HentPerson(int personid)
        {
            return await repo.HentPerson(personid);
        }

        [HttpPost("opret")]
        public async void OpretPerson(PersonDTO NyPerson)
        {
            Console.WriteLine("controller fandt opret");
            repo.OpretPerson(NyPerson);

        }

        [HttpPut("opdaterperson")]
        public async void OpdaterPerson(PersonDTO NyPerson)
        {
            repo.OpdaterPerson(NyPerson);

        }

    }
}