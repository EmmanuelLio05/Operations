using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Operations.Models {
    public class Response {
        #region Atributos
        private double dResult = 0;
        private HttpStatusCode eStatus = HttpStatusCode.OK;
        #endregion

        #region Propertys
        public double Result {
            get { return dResult; }
            set { dResult = value; }
        }

        public HttpStatusCode Status {
            get { return eStatus; }
            set { eStatus = value; }
        }
        #endregion

        #region Methods
        public Response() { }

        public Response(double dResult, HttpStatusCode eStatus) {
            this.dResult = dResult;
            this.eStatus = eStatus;
        }
        #endregion
    }
}
