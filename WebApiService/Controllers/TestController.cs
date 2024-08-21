using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiService.Controllers
{
    public class TestController : ApiController
    {
        static List<String> Colors = new List<String>()
        {
        "Blue","White","Black","Pink","Red","Yellow","Voilet","Green","Purple","Mangenta"
        };
        [HttpGet]
        public IEnumerable<String>DisplayColors()
            {
            return Colors; 
            }
        [HttpGet]
        public String DisplayColor(int Id)
        {
            return Colors[Id];
        }
        public void Post([FromBody]string color)
        {
            Colors.Add(color);
        }
        public void Put(int Id, [FromBody] string color)
        {
            Colors[Id] = color;
        }
        public void Delete(int Id)
        {
            Colors.RemoveAt(Id);
        }
    }
}
