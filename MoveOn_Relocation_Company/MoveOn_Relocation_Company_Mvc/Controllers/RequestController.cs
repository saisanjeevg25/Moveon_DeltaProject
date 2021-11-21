using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MoveOn_Relocation_Company_Mvc.Helper;
using MoveOn_Relocation_Company_Mvc.Models;
using Newtonsoft.Json;

namespace MoveOn_Relocation_Company_Mvc.Controllers
{
    public class RequestController : Controller
    {
        private readonly MOVEON_DBContext _context;
        RequestApi _api = new RequestApi();

        public RequestController(MOVEON_DBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> View_Domestic_Requests()
        {
            List<Request> domreqs = new List<Request>();
            HttpClient cli = _api.Initial();
            HttpResponseMessage result = await cli.GetAsync("api/TblRequests/DomesticRequests");
            if (result.IsSuccessStatusCode)
            {
                var res = result.Content.ReadAsStringAsync().Result;
                domreqs = JsonConvert.DeserializeObject<List<Request>>(res);
            }
            return View(domreqs);
        }

        public async Task<IActionResult> View_International_Requests()
        {
            List<Request> intreqs = new List<Request>();
            HttpClient cli = _api.Initial();
            HttpResponseMessage result = await cli.GetAsync("api/TblRequests/InternationalRequests");
            if (result.IsSuccessStatusCode)
            {
                var res = result.Content.ReadAsStringAsync().Result;
                intreqs = JsonConvert.DeserializeObject<List<Request>>(res);
            }
            return View(intreqs);
        }

        public async Task<IActionResult> View_Job_Application_Number(string id)
        {
            var reqs = new Request();
            HttpClient cli = _api.Initial();
            HttpResponseMessage result = await cli.GetAsync($"api/TblRequests/{id}");
            if (result.IsSuccessStatusCode)
            {
                var res = result.Content.ReadAsStringAsync().Result;
                reqs = JsonConvert.DeserializeObject<Request>(res);
            }
            return View(reqs);
        }

        public async Task<IActionResult> View_Int_Job_Application_Number(string id)
        {
            var reqs = new Request();
            HttpClient cli = _api.Initial();
            HttpResponseMessage result = await cli.GetAsync($"api/TblRequests/{id}");
            if (result.IsSuccessStatusCode)
            {
                var res = result.Content.ReadAsStringAsync().Result;
                reqs = JsonConvert.DeserializeObject<Request>(res);
            }
            return View(reqs);
        }

        public ActionResult Add_request()
        {
            Request req = new Request();
            var lastintid =
            ViewBag.Countries = new SelectList(_context.TblCountries, "CountryName", "CountryName");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add_request(Request request)
        {
            HttpClient cli = _api.Initial();
            string authornew = JsonConvert.SerializeObject(request);
            StringContent content = new StringContent(authornew, Encoding.UTF8, "application/json");
            HttpResponseMessage response = cli.PostAsync(cli.BaseAddress + "api/TblRequests", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(actionName: "Index", controllerName: "Home");
            }
            return View();
        }

        public JsonResult State_dropdown(string name)
        {
            var countryid = _context.TblCountries.Where(e => e.CountryName == name).Select(s => s.Id).First();
            var state = _context.TblStates.Where(o => o.CountryId == countryid).ToList();
            return Json(new SelectList(state, "StateName", "StateName"));
        }

        public JsonResult City_dropdown(string name)
        {
            var stateid = _context.TblStates.Where(e => e.StateName == name).Select(s => s.Id);
            var city = _context.TblCities.Where(o => o.StateId == stateid.First()).ToList();
            return Json(new SelectList(city, "CityName", "CityName"));
        }
    }
}
