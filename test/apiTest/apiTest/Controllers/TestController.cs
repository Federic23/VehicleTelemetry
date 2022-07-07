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

        //private ICluster _cluster;
        //private ISession _session;
        //private IMapper _mapper;

        //public TestController()
        //{
        //    _cluster = Cluster.Builder()
        //        .AddContactPoint("127.0.0.1").WithPort(9042).Build();


        //    _session = _cluster.Connect();
        //    try
        //    {
        //        _session = _cluster.Connect("vehicle_telemetry_key");
        //    }
        //    catch (Exception)
        //    {
        //        _session.Execute(@"CREATE KEYSPACE vehicle_telemetry_key WITH REPLICATION = {'class' : 'SimpleStrategy', 'replication_factor' : 1};");

        //        _session.Execute(@"CREATE TABLE IF NOT EXISTS users ( 
        //                      id      INT,
        //                      numero      INT,
        //                      PRIMARY KEY (( id )));");

        //        _session = _cluster.Connect("vehicle_telemetry_key");
        //    }

        //    _session.Execute(@"CREATE TABLE IF NOT EXISTS users ( 
        //                      id      INT,
        //                      numero      INT,
        //                      PRIMARY KEY (( id )));");

        //    _mapper = new Mapper(_session);
        //}

        //[HttpGet]
        //[Route("api/post")]
        //public IHttpActionResult Post()
        //{
        //    Test testeo = new Test { id = 4, numero = 8 };

        //    _mapper.Insert(testeo);

        //    var listOfPosts = _mapper.Fetch<Test>();

        //    return Ok(listOfPosts.ToList());
        //}
    }
}