using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Collections.Generic;

namespace WebApplication1.Controllers
{
   
    public class AutomationController : Controller
    {

        HttpClient client;
        // GET: Automation
        public ActionResult Index()
        {
            return View();
        }

        public async Task<JsonResult> GetMotionSensorDetail()
        {
            var type = "motionsensor";
            HttpResponseMessage response = await GetClient(type).GetAsync(type);
            if (response.IsSuccessStatusCode)
            {
                List<SensorData> sensorData = await response.Content.ReadAsAsync<List<SensorData>>();

            }

            return new JsonResult();

        }

        public async Task<JsonResult> GetTempSensorDetail()
        {
            var type = "tempsensor";
            HttpResponseMessage response = await GetClient(type).GetAsync(type);
            if (response.IsSuccessStatusCode)
            {
                List<SensorData> sensorData = await response.Content.ReadAsAsync<List<SensorData>>();

            }
            
            return new JsonResult();

        }

        public HttpClient GetClient(string type)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://honmdu10june2017.mybluemix.net/3/" + type);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }
    }
}