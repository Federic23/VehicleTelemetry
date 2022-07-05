using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using apiTest.Models;
using Cassandra;
using Cassandra.Mapping;

namespace apiTest.Controllers
{
    public class TestController : ApiController
    {

        private ICluster _cluster;
        private ISession _session;
        private IMapper _mapper;

        public TestController()
        {
            _cluster = Cluster.Builder()
                .AddContactPoint("127.0.0.1").WithPort(9042).Build();
            
            //.WithCloudSecureConnectionBundle(@"C:\Users\Usuario\Desktop\New folder\Project\VehicleTelemetry\test\apiTest\apiTest\secure-connect-vehicletelemetry.zip")
            //.WithCredentials("OPrQXmDfCZelSdaYDEEXIGjT", "7XZ2ZCkYksMGfysQF8B2tX4LwaRxOZUc,_Ds9ZQ.hlZzwg+vXAMJyR4dYrMKC-22vvzaArEUhZkhQ0aYZ05DSNP9ZBg5M..aG7-tRjefwaeksB01Er9s+MzLZ7EZCmge")


            _session = _cluster.Connect("vehicle_telemetry_key");
            _mapper = new Mapper(_session);
        }

        [HttpGet]
        [Route("api/post")]
        public IHttpActionResult Post()
        {
            Test testeo = new Test { id = 4, numero = 8 };

            _mapper.Insert(testeo);

            var listOfPosts = _mapper.Fetch<Test>();

            return Ok(listOfPosts.ToList());
        }
    }
}