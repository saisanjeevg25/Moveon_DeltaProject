using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoveOn_Application_Mvc.Helper;
using MoveOn_Application_Mvc.Models;
using Newtonsoft.Json;

namespace MoveOn_Application_Mvc.Controllers
{
    public class RequestController : Controller
    {
        RequestApi _api = new RequestApi();
        public async Task<IActionResult> View_Domestic_Requests()
        {
            List<Request> domreqs = new List<Request>();
            HttpClient cli = _api.Initial();
            HttpResponseMessage result = await cli.GetAsync("api/TblRequests/DomesticRequests/1");
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
            HttpResponseMessage result = await cli.GetAsync("api/TblRequests/InternationalRequests/2");
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
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add_request(Request request)
        {
            HttpClient cli = _api.Initial();
            string authornew = JsonConvert.SerializeObject(request);
            HttpContext.Session.SetString("RequestSession", authornew);
            StringContent content = new StringContent(authornew, Encoding.UTF8, "application/json");
            HttpResponseMessage response = cli.PostAsync(cli.BaseAddress + "api/TblRequests", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();

        }
    }
}
