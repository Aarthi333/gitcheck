using day27_Client.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
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

//[assembly: Guid("f63d3e2d-87a5-4ae8-ba5d-e98e89404599")]

//namespace day27_Client.Controllers
//{
//    public class CustomerController : Controller
//    {
//        //customers_registered_list
//        public async Task<ActionResult> Index()
//        {
//            string Baseurl = "http://localhost:29518/";  //http://localhost:29518/api/Customers
//            var ProdInfo = new List<Customer>();
//            using (var client = new HttpClient())
//            {
//                client.BaseAddress = new Uri(Baseurl);
//                client.DefaultRequestHeaders.Clear();
//                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
//                HttpResponseMessage Res = await client.GetAsync("api/Customers");
//                if (Res.IsSuccessStatusCode)
//                {
//                    //Storing the response details recieved from web api   
//                    var ProdResponse = Res.Content.ReadAsStringAsync().Result;
//                    //Deserializing the response recieved from web api and storing into the Employee list  
//                    ProdInfo = JsonConvert.DeserializeObject<List<Customer>>(ProdResponse);
//                }
//                //returning the employee list to view  
//                return View(ProdInfo);
//            }
//        }
//        //bookings_list
//        public async Task<ActionResult> BookingIndex()
//        {
//            string Baseurl = "http://localhost:29518/";  
//            var ProdInfo = new List<Booking>();
//            using (var client = new HttpClient())
//            {
//                client.BaseAddress = new Uri(Baseurl);
//                client.DefaultRequestHeaders.Clear();
//                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
//                HttpResponseMessage Res = await client.GetAsync("api/Bookings");
//                if (Res.IsSuccessStatusCode)
//                {
//                    //Storing the response details recieved from web api   
//                    var ProdResponse = Res.Content.ReadAsStringAsync().Result;
//                    //Deserializing the response recieved from web api and storing into the Employee list  
//                    ProdInfo = JsonConvert.DeserializeObject<List<Booking>>(ProdResponse);
//                }
//                //returning the employee list to view  
//                return View(ProdInfo);
//            }
//        }
//        //orderdetails_list
//        public async Task<ActionResult> OrderDetailsIndex()
//        {
//            string Baseurl = "http://localhost:29518/";
//            var ProdInfo = new List<OrderDetails>();
//            using (var client = new HttpClient())
//            {
//                client.BaseAddress = new Uri(Baseurl);
//                client.DefaultRequestHeaders.Clear();
//                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
//                HttpResponseMessage Res = await client.GetAsync("api/OrderDetails");
//                if (Res.IsSuccessStatusCode)
//                {
//                    //Storing the response details recieved from web api   
//                    var ProdResponse = Res.Content.ReadAsStringAsync().Result;
//                    //Deserializing the response recieved from web api and storing into the Employee list  
//                    ProdInfo = JsonConvert.DeserializeObject<List<OrderDetails>>(ProdResponse);
//                }
//                //returning the employee list to view  
//                return View(ProdInfo);
//            }
//        }


//        //registercustomer
//        [HttpGet]
//        public ActionResult Create()
//        {
//            return View();
//        }
//        [HttpPost]
//        public async Task<ActionResult> Create(Customer sbt)
//        {
//            using (var httpClient = new HttpClient())
//            {
//                StringContent content = new StringContent(JsonConvert.SerializeObject(sbt), Encoding.UTF8, "application/json");

//                using (var response = await httpClient.PostAsync("http://localhost:29518/api/Customers", content))
//                {
//                    string apiResponse = await response.Content.ReadAsStringAsync();
//                    var obj = JsonConvert.DeserializeObject<Customer>(apiResponse);
//                }
//            }
//            return RedirectToAction("GetProduct");
//        }
//        //displayproduct
//        [HttpGet]
//        [Route("Product")]
//        public async Task<List<Product>> GetProduct()  
//        {
//            string Baseurl = "http://localhost:29518/";  //http://localhost:29518/api/Customers/Product
//            var ProdInfo = new List<Product>();
//            using (var client = new HttpClient())
//            {
//                client.BaseAddress = new Uri(Baseurl);
//                client.DefaultRequestHeaders.Clear();
//                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
//                HttpResponseMessage Res = await client.GetAsync("api/Customers/Product");
//                if (Res.IsSuccessStatusCode)
//                {
//                    //Storing the response details recieved from web api   
//                    var ProdResponse = Res.Content.ReadAsStringAsync().Result;
//                    //Deserializing the response recieved from web api and storing into the Employee list  
//                    ProdInfo = JsonConvert.DeserializeObject<List<Product>>(ProdResponse);
//                }
//                //returning the employee list to view  
//                return ProdInfo;              
//            }
//        }
//        //do the booking
       
//    }
//}
