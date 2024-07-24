using Microsoft.AspNetCore.Mvc;
using MVC_Consume_FlightWebPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Consume_FlightWebPI.Controllers
{
    public class FlightsController : Controller
    {
        Uri BaseAddress = new Uri("http://localhost:34169/api");
        private readonly HttpClient _client;
        public FlightsController()
        {
            _client = new HttpClient();
            _client.BaseAddress = BaseAddress;
          
        }
        [HttpGet]
            public ActionResult Index()
        {
            List<Flight> flightList = new List<Flight>();
            HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "/Flights").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                flightList= JsonConvert.DeserializeObject<List<Flight>>(data);
            }
            return View(flightList);
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            try
            {
                Flight flight = new Flight();
                HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "/Flights/" + id).Result;
                if (response.IsSuccessStatusCode)
                {
                    string data = response.Content.ReadAsStringAsync().Result;
                    flight = JsonConvert.DeserializeObject<Flight>(data);
                }
                return View(flight);
            }
            catch (Exception ex)
            {

                TempData["errormsg"] = ex.Message;
                return View();
            }
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View();

        }
        [HttpPost]
        public ActionResult Create(Flight model)
        {

            try
            {
                string data = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = _client.PostAsync(_client.BaseAddress + "/Flights", content).Result;
                if (response.IsSuccessStatusCode)
                {
                    TempData["successmsg"] = "Flight Entered";
                    return RedirectToAction("Index");
                }

            }
            catch (Exception ex)
            {

                TempData["errormsg"] = ex.Message;
                return View();
            }


            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            try
            {
            Flight  flight = new Flight();
                HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "/Flights/" + id).Result;
                if (response.IsSuccessStatusCode)
                {
                    string data = response.Content.ReadAsStringAsync().Result;
                    flight = JsonConvert.DeserializeObject<Flight>(data);
                }
                return View(flight);
            }
            catch (Exception ex)
            {

                TempData["errormsg"] = ex.Message;
                return View();
            }

        }

        [HttpPost]
        
        public ActionResult Edit(int id,Flight model)
        {

            try
            {
                string data = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = _client.PutAsync(_client.BaseAddress + "/Flights/"+id, content).Result;
                if (response.IsSuccessStatusCode)
                {
                    TempData["successmsg"] = "flight updated";
                    return RedirectToAction("Index");
                }

            }
            catch (Exception ex)
            {

                TempData["errormsg"] = ex.Message;
                return View();
            }


            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            try
            {
                Flight flight = new Flight();
                HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "/Flights/" + id).Result;
                if (response.IsSuccessStatusCode)
                {
                    string data = response.Content.ReadAsStringAsync().Result;
                    flight= JsonConvert.DeserializeObject<Flight>(data);

                }
                return View(flight);
            }
            catch (Exception ex)
            {
                TempData["errormsg"] = ex.Message;
                return View();
            }


        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            try
            {
                HttpResponseMessage response = _client.DeleteAsync(_client.BaseAddress + "/Flights/" + id).Result;
                if (!response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["errormsg"] = ex.Message;
                return View();
            }

            return View();
        }
    }







}