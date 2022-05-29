using Newtonsoft.Json;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using UserListWithPagination.Models;

namespace UserListWithPagination.Controllers
{
    public class UserController : Controller
    {
        Uri baseAddress = new Uri("https://reqres.in/api/users?page=2");
        HttpClient client;
        public UserController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }
        public ActionResult Index()
        {
            APIData data =new APIData();
            List<UserData> modelList = new List<UserData>();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress).Result;
            if (response.IsSuccessStatusCode)
            {
                string responseBody = response.Content.ReadAsStringAsync().Result;
                data = JsonConvert.DeserializeObject<APIData>(responseBody);
                modelList = data.data
                    .OrderBy(u => u.first_name)
                    .ToList();
            }
            return View(modelList);
        }
    }
}