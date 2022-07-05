using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiTest.Models
{
    public class Register
    {

        public int car_id { get; set; }
        public String zone { get; set; }
        public String data { get; set; }
        public int month { get; set; }
        public int day { get; set; }
        public int temperature { get; set; }
        public int waves { get; set; }

        public Register()
        {

        }

    }
}