using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// In SDK-style projects such as this one, several assembly attributes that were historically
// defined in this file are now automatically added during build and populated with
// values defined in project properties. For details of which attributes are included
// and how to customise this process see: https://aka.ms/assembly-info-properties


// Setting ComVisible to false makes the types in this assembly not visible to COM
// components.  If you need to access a type in this assembly from COM, set the ComVisible
// attribute to true on that type.

[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM.

[assembly: Guid("6de9f032-d883-4fbc-9f9d-d74383b29f32")]

namespace day27_Client.Models
{
    public class Customer
    {
        public int Customer_ID { get; set; }
        public string FirstName { get; set; }
        public string Age { get; set; }
        public string LastName { get; set; }

    }
}

