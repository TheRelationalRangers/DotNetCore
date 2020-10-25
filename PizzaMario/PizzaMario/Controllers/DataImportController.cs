using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaMario.Services.ExcelReader;

namespace PizzaMario.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataImportController : ControllerBase
    {
        private readonly IExcelImportService _excelImportService;

        public DataImportController(IExcelImportService excelImportService)
        {
            _excelImportService = excelImportService;
        }

        [HttpPost("import/crusts")]
        public async Task<IActionResult> ImportCrustsAsync(IFormFile file)
        {
            try
            {
                var result = await _excelImportService.ImportCrustFromExcelFile(file).ConfigureAwait(false);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
