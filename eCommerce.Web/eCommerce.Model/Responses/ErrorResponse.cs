using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Model.Responses
{
    public class ErrorResponse : BaseResponse
    {
        public ErrorResponse()
        {
            // if error set success to false
            this.IsSuccessful = false;
        }
    }
}
