﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Model.Responses
{
    public class BaseResponse
    {
        public bool IsSuccessful { get; set; }

        public string TransactionId { get; set; }

        public BaseResponse()
        {
            // Creates a unique id for each transaction
            this.TransactionId = Guid.NewGuid().ToString();
        }
    }
}
