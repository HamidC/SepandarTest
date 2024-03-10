using Microsoft.AspNetCore.Mvc;
using SepandarTest.Model;
using SepandarTest.Persistence;

namespace SepandarTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SepandarController : ControllerBase
    {
        public DatabaseMockup DatabaseMockup { get; set; }

        public SepandarController(DatabaseMockup databaseMockup)
        {
            DatabaseMockup = databaseMockup;
        }

        [HttpPost("[Action]")]
        public async Task<IActionResult> GetMobileByPlkBatch([FromBody] List<GetMobileByPlkModel> model)
        {
            try
            {
                return Ok(await DatabaseMockup.GetMobileByPlkBatch(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Successful = false, ErrorCode = "500", ErrorDescription = ex.Message });
            }
        }
    }
}