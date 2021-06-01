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

//[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM.

//[assembly: Guid("cb41ffd3-6cd3-4a58-8238-e6f2dc1d162b")]
namespace day27_Client.Models
{
    public class OrderDetails
    {
        public int OrderDetails_ID { get; set; }
        public string Customer_FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Pincode { get; set; }
        public string OrderTime { get; set; }
        public int Quantity_1 { get; set; }
        public int Quantity_2 { get; set; }
        public int Quantity_3 { get; set; }
        public string Crust { get; set; }
        public string Suggestions { get; set; }
        public string Additional { get; set; }

        //public int OrderDetails_ID { get; set; }
        //public string Customer_FullName { get; set; }
        //public string Pizza_Name { get; set; }
        //public string Quantity_Needed { get; set; }
        //public string Crust { get; set; }
        //public string Suggestions { get; set; }


    }
}
