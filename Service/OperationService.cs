using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Multiple.Service
{
    public class OperationService
    {

        public static Boolean IsMultipleOf3(string value) {
            var sum = value.ToCharArray().Sum(i => Convert.ToInt32(i.ToString()));
            var result= sum % 3 == 0;
            return result;

        }
    }
}
