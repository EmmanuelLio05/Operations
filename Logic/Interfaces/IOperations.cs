using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models = Operations.Models;

namespace Operations.Logic.Interfaces {
    public interface IOperations {
        public Task<Models.Response> Add(Tuple<double,double> tSumandos);

        public Task<Models.Response> Subtraction(Tuple<double, double> tMinSus);

        public Task<Models.Response> Multiplication(Tuple<double, double> tMultiplicandoMultiplicador);

        public Task<Models.Response> Division(Tuple<double, double> tDividendoDivisor);
    }
}
