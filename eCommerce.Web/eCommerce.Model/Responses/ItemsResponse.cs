using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Model.Responses
{
    public class ItemsResponse<T> : SuccessResponse
    {
        // for multiple items
        public List<T> items { get; set; }
    }
}
