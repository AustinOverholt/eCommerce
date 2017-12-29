using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Model.Responses
{
    public class SuccessResponse : BaseResponse
    {
        public SuccessResponse()
        {
            // if success then success is true
            this.IsSuccessful = true;
        }
    }
}
