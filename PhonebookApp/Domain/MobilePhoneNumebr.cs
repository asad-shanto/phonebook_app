using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PhonebookApp.Domain
{
    public class MobilePhoneNumebr :  PhoneNumber
    {
        public int OperatorCode { get; set; }
        public static class Operator {
            public static int TELETALK = 5;
            public static int AIRTEL = 6;
            public static int GRAMEEN_PHONE = 7;
            public static int ROBI = 8;
            public static int BANGLALINK = 9;
        }
    }
}