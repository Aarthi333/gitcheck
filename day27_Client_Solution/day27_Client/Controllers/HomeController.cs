using day27_Client.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace day27_Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        static List<Review> reviews = new List<Review>()
            {
                new Review() {Name= "Santhosh from besant nagar" ,CommentText="nice pizzas.loved it!!!"},
                new Review() {Name=" Meera from ecr" ,CommentText="I loved the veg pizza!" },
                new Review() {  Name= "Emi from Mylapore",CommentText="Chicken pizza was good.Delivery was fast"}
            };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger; 
        }

        public IActionResult Index()
        {

            return View();
        }
        
        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ProductView() //pizzaimagespage
        {
            return View();

        }
        [HttpGet]
        public ActionResult CreateOrderDetails()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> CreateOrderDetails(OrderDetails sbt)   
        {
            try
            {
                using (var httpClient = new HttpClient())    //http://localhost:29518/api/OrderDetails
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(sbt), Encoding.UTF8, "application/json");

                    using (var response = await httpClient.PostAsync("http://localhost:29518/api/OrderDetails", content))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        var obj = JsonConvert.DeserializeObject<OrderDetails>(apiResponse);
                        TempData["OrderDetails_ID"] = obj.OrderDetails_ID;  //change
                    }
                }
                return RedirectToAction("OrderConfirm");  
            }
            catch
            {
                return RedirectToAction("Error");
            }
        }
        public ActionResult  OrderConfirm()
        {
            return View();
        }
        public ActionResult Review()
        {
            return View();
        }

        //orderedit
        public async Task<ActionResult> EditOrder(int id)
        {
            TempData["OrderDetails_ID"] = id;
            OrderDetails b = new OrderDetails();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:29518/api/OrderDetails/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    b = JsonConvert.DeserializeObject<OrderDetails>(apiResponse);
                }
            }
            return View(b);
        }
        [HttpPost]
        public async Task<ActionResult> EditOrder(OrderDetails b)
        {
            int vid = Convert.ToInt32(TempData["OrderDetails_ID"]);
            b.OrderDetails_ID = vid;
            OrderDetails receivedemp = new OrderDetails();
            using (var httpClient = new HttpClient())
            {
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(b), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("http://localhost:29518/api/OrderDetails/" + vid, content1))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    receivedemp = JsonConvert.DeserializeObject<OrderDetails>(apiResponse);
                }
            }
            return RedirectToAction("Index");
        }
        //pizzadbview
        [HttpGet]
        public async Task<ActionResult> PizzaIndex()
        {
            string Baseurl = "http://localhost:29518/";  //http://localhost:29518/api/Products
            var ProdInfo = new List<Product>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/Products");
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var ProdResponse = Res.Content.ReadAsStringAsync().Result;
                    //Deserializing the response recieved from web api and storing into the Employee list  
                    ProdInfo = JsonConvert.DeserializeObject<List<Product>>(ProdResponse);
                }
                //returning the employee list to view  
                return View(ProdInfo);
            }
        }
        //ordersummary

        public async Task<ActionResult> OrderDetailsIndex()
        {
            string Baseurl = "http://localhost:29518/";
            var ProdInfo = new List<OrderDetails>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/OrderDetails");
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var ProdResponse = Res.Content.ReadAsStringAsync().Result;
                    //Deserializing the response recieved from web api and storing into the Employee list  
                    ProdInfo = JsonConvert.DeserializeObject<List<OrderDetails>>(ProdResponse);
                }
                //returning the employee list to view  
                return View(ProdInfo);
            }
        }
        public async Task<ActionResult> OrderSummary(int id) //http://localhost:29518/api/OrderDetails/1
        {
            
            OrderDetails b = new OrderDetails();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:29518/api/OrderDetails/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    b = JsonConvert.DeserializeObject<OrderDetails>(apiResponse);
                }
            }
            return View(b);
        }
        //review 
        public IActionResult ReviewIndex()
        {
            return View(reviews);
        }
        public IActionResult AddReview()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddReview(Review review)
        {
            reviews.Add(review);
            return RedirectToAction("ReviewIndex");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
