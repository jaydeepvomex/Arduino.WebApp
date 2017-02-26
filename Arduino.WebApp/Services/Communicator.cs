using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Arduino.WebApp.Services
{
    public class CommunicatorController : ApiController
    {
        public CommunicatorController()
        {

        }

        [HttpGet]
        [Route("Arduino")]
        public HttpResponseMessage GetData()
        {
            SerialPort port = new SerialPort("COM3", 9200);
            port.Open();
            string s = port.ReadLine();
            port.Write(s + '\n');
            port.Close();

            return Request.CreateResponse(HttpStatusCode.OK, s);            
        }

    }
}