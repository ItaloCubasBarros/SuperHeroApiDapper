using Dapper;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SuperHeroApi_DotNet8.Data;
using SuperHeroApi_DotNet8.Entity;
using System.Data.SqlClient;

namespace SuperHeroApi_DotNet8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly string _connectionString;

        public SuperHeroController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }



        [HttpGet]
        public async Task<IActionResult> GetAllHeroes()
        {
            using (var sqlConnection = new System.Data.SqlClient.SqlConnection(_connectionString))
            {
                const string sql = "SELECT * FROM SuperHeroes";

                var heroes = await sqlConnection.QueryAsync<SuperHero>(sql);

                return Ok(heroes);
            }

            
        }

        
        [HttpGet("{id}")]
       
        public async Task<IActionResult> GetHeroById(int id)
        {
            var parameters = new
            {
                id
            };

            using (var sqlConnection = new System.Data.SqlClient.SqlConnection(_connectionString))
            {
                const string sql = "SELECT * FROM SuperHeroes Where Id = @id";

                var hero = await sqlConnection.QuerySingleOrDefaultAsync<SuperHero>(sql, parameters);

                if (hero is null)
                {
                    return NotFound();
                }
                return Ok(hero);
            }
                
        }

        [HttpPost]
        public async Task<IActionResult> Post(SuperHeroInputModel model)
        {

            using (var sqlConnection = new System.Data.SqlClient.SqlConnection(_connectionString))
            {
                const string sql = "INSERT INTO SuperHeroes (Name, FirstName, LastName, Place) VALUES (@Name, @FirstName, @LastName, @Place)";
                var id = await sqlConnection.ExecuteScalarAsync<int>(sql, model);

                return Ok(id);
            }
        }

        [HttpPut("{id}")]

        public async Task<ActionResult> Put(int id, SuperHeroInputModel model)
        {
            using (var sqlConnection = new System.Data.SqlClient.SqlConnection(_connectionString))
            {
                const string sql = "UPDATE SuperHeroes SET Name = @Name, FirstName = @FirstName, LastName = @LastName, Place = @Place WHERE ID = @id";
                model.Id = id; 
                await sqlConnection.ExecuteAsync(sql, model);

                return NoContent();
            }

        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            var parameters = new
            {
                id,

            };

            using (var sqlConnection = new System.Data.SqlClient.SqlConnection(_connectionString))
            {
                const string sql = "DELETE FROM  SuperHeroes WHERE ID = @id";

                await sqlConnection.ExecuteAsync(sql, parameters);


                return NoContent();
            }
           
        }
        
    }
}
