using Operations.Logic.Interfaces;
using Operations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Operations.Logic.Implementations {
    public class OperationsImplementation : IOperations {
        public async Task<Response> Add(Tuple<double, double> tSumandos) {
            try {
                return new Response(tSumandos.Item1 + tSumandos.Item2, System.Net.HttpStatusCode.OK);
            } catch (Exception ex) {
                return new Response(0, System.Net.HttpStatusCode.BadRequest);
            }
        }

        public async Task<Response> Subtraction(Tuple<double, double> tMinSus) {
            try {
                return new Response(tMinSus.Item1 - tMinSus.Item2, System.Net.HttpStatusCode.OK);
            } catch (Exception ex) {
                return new Response(0, System.Net.HttpStatusCode.BadRequest);
            }
        }

        public async Task<Response> Division(Tuple<double, double> tDividendoDivisor) {
            try {
                return new Response(tDividendoDivisor.Item1 / tDividendoDivisor.Item2, System.Net.HttpStatusCode.OK);
            } catch (Exception ex) {
                return new Response(0, System.Net.HttpStatusCode.BadRequest);
            }
        }

        public async Task<Response> Multiplication(Tuple<double, double> tMultiplicandoMultiplicador) {
            try {
                return new Response(tMultiplicandoMultiplicador.Item1 * tMultiplicandoMultiplicador.Item2, System.Net.HttpStatusCode.OK);
            } catch (Exception ex) {
                return new Response(0, System.Net.HttpStatusCode.BadRequest);
            }
        }
    }
}
