using Microsoft.AspNetCore.Mvc;
using Operations.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models = Operations.Models;

namespace Operations.Controllers {
    [ApiController]
    [Route("api/v1/[controller]")]
    public class OperationsController : Controller {
        private readonly IOperations operations;

        public OperationsController(IOperations operations) {
            this.operations = operations;
        }


        [HttpPost("Add")]
        public async Task<IActionResult> Add(Tuple<double, double> tSumandos) {
            Models.Response oResponse = await operations.Add(tSumandos);

            if (oResponse.Status == System.Net.HttpStatusCode.OK) {
                return Ok(oResponse.Result);
            } else {
                return BadRequest();
            }
        }

        [HttpPost("Subtraction")]
        public async Task<IActionResult> Subtraction(Tuple<double, double> tMinSus) {
            Models.Response oResponse = await operations.Subtraction(tMinSus);

            if (oResponse.Status == System.Net.HttpStatusCode.OK) {
                return Ok(oResponse.Result);
            } else {
                return BadRequest();
            }
        }

        [HttpPost("Multiplication")]
        public async Task<IActionResult> Multiplication(Tuple<double, double> tMultiplicandoMultiplicador) {
            Models.Response oResponse = await operations.Multiplication(tMultiplicandoMultiplicador);

            if (oResponse.Status == System.Net.HttpStatusCode.OK) {
                return Ok(oResponse.Result);
            } else {
                return BadRequest();
            }
        }

        [HttpPost ("Division")]
        public async Task<IActionResult> Division(Tuple<double, double> tDividendoDivisor) {
            Models.Response oResponse = await operations.Division(tDividendoDivisor);

            if (oResponse.Status == System.Net.HttpStatusCode.OK) {
                return Ok(oResponse.Result);
            } else {
                return BadRequest();
            };
        }
    }
}
