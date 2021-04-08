using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;
using Techchef_2.Models;

namespace Techchef_2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        string Baseurl = "https://reqres.in/";
        public async Task<ActionResult> Index(int id)
        {
            Root root = new Root();
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/users/"+id);
                if (Res.IsSuccessStatusCode)
                {
                    string Response = Res.Content.ReadAsStringAsync().Result;
                    root = JsonConvert.DeserializeObject<Root>(Response);
                }
                return View(root);
            }
        }


    }
    }

   