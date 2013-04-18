using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace PhonebookApp.Domain
{
    public class Contact
    {
        public String Name { get; set; }

        //ArrayList of Number
        public ArrayList Numbers { get; set; }
        public String[] Emails { get; set; }
        public String ImageLink { get; set; }
        public String Address;
        public PhoneNumber OfficeContact { get; set; }
        public PhoneNumber HomeNumber { get; set; }
    }
}