using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhonebookApp.Domain
{
    //A basic PhoneNumber Class can be any Mobile or TNT number
    //But only adviced to user with TNT
    public class PhoneNumber
    {
        //+88 (if we want to extend for multile country)
        public String CountyrCode { get; set; }

        //01 for mobile, 02 for LAN phone
        public String PhoneTypeCode { get; set; }

        //other part of number 
        //76763997 where full number is [+88][01][6]76763997
        //                              [conuntyCode][PhoneTypeCode][Operator]  
        public String Number { get; set; }
        
    }
}