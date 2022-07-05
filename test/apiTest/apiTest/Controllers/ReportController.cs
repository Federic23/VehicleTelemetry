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
    public class ReportController : ApiController
    {
        //private ICluster _cluster;
        //private ISession _session;
        //private IMapper _mapper;

        //public ReportController()
        //{
        //    _cluster = Cluster.Builder()
        //                .WithCloudSecureConnectionBundle(@"C:\Users\Usuario\Desktop\New folder\Project\VehicleTelemetry\Api\Api\secure-connect-vehicletelemetry.zip")
        //                .WithCredentials("OPrQXmDfCZelSdaYDEEXIGjT", "7XZ2ZCkYksMGfysQF8B2tX4LwaRxOZUc,_Ds9ZQ.hlZzwg+vXAMJyR4dYrMKC-22vvzaArEUhZkhQ0aYZ05DSNP9ZBg5M..aG7-tRjefwaeksB01Er9s+MzLZ7EZCmge")
        //                .Build();

        //    _session = _cluster.Connect("vehicle_telemetry_key");
        //    _mapper = new Mapper(_session);
        //}

        //[HttpGet]
        //[Route("api/get")]
        //public IHttpActionResult Post()
        //{
        //    Test testeo = new Test { id = 4, numero = 8 };

        //    _mapper.Insert(testeo);

        //    var listOfPosts = _mapper.Fetch<Test>();

        //    return Ok(listOfPosts.ToList());
        //}
    }
}