using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaginationWebApi.Data;
using PaginationWebApi.Models;

namespace PaginationWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaginationController : ControllerBase
    {
        public readonly PaginationContext context;
        public PaginationController(PaginationContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("/getData")]
        public async Task<IActionResult> GetData(int count, int page)
        {
            Console.WriteLine(count);
            var list = context.UserDetails.FromSql($"SELECT  * FROM UserDetails ORDER BY id  OFFSET {count * (page-1)} ROWS  FETCH NEXT {count} ROWS ONLY").ToList();
            int totalCount = context.UserDetails.Count();
            //var list = await context.UserDetails.ToListAsync();
            return Ok(new { list, totalCount });
        }

        [HttpGet]
        [Route("/getAllData")]
        public async Task<IActionResult> GetAllData()
        {
            var list = await context.UserDetails.ToListAsync();
            return Ok(list);
        }
    }
}
