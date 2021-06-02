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

//[assembly: Guid("5cd18eb3-389f-420a-a64d-20dc1391d525")]

namespace day27_Client.Models
{
    public class Product
    {
        public int Pizza_Id { get; set; }
        public string Pizza_Name { get; set; }
        public float Price { get; set; }
        public string Crust { get; set; }
        public string Toppings { get; set; }
        public string IsVeg { get; set; }
        public string Description { get; set; }
        //public int Pizza_Id { get; set; }
        //public string Pizza_Name { get; set; }
        //public float Price { get; set; }
        //public int Quantity { get; set; }
        //public string Description { get; set; }
    }
}
