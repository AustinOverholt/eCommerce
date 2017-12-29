using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Model.Responses
{
    public class ItemResponse<T> : SuccessResponse
    {
        // for single items
        public T item { get; set; }
    }
}
