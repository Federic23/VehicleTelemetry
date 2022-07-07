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
        private ICluster _cluster;
        private ISession _session;
        private IMapper _mapper;

        public ReportController()
        {
            _cluster = Cluster.Builder()
                .AddContactPoint("127.0.0.1").WithPort(9042).Build();


            _session = _cluster.Connect();
            try
            {
                _session = _cluster.Connect();
                _session = _cluster.Connect("vehicle_telemetry_key");
            }
            catch (Exception)
            {
                _session.Execute(@"CREATE KEYSPACE vehicle_telemetry_key WITH REPLICATION = {'class' : 'SimpleStrategy', 'replication_factor' : 1};");

                _session.Execute(@"CREATE TABLE IF NOT EXISTS users ( 
                              id      INT,
                              numero      INT,
                              PRIMARY KEY (( id )));");

                _session = _cluster.Connect("vehicle_telemetry_key");
            }

            


            _mapper = new Mapper(_session);
        }

        [HttpPost]
        [Route("api/initialize")]
        public IHttpActionResult Initialize()
        {
            _session.Execute(@"CREATE TABLE IF NOT EXISTS registers(
                                  zone TEXT,
                                  car_id INT,
                                  registerDate TIMESTAMP,
                                  month INT,
                                  day INT,
                                  temperature INT,
                                  waves INT,
                                  data TEXT,
                                  PRIMARY KEY ((zone, month, day), registerDate, car_id));");

            { 
            Register registro1 = new Register
            {
                car_id = 1,
                month = DateTime.Now.Month,
                day = DateTime.Now.Day,
                zone = "usa",
                registerDate = DateTime.UtcNow,
                waves = 250,
                temperature = 37,
                data = "ok"
            };

            Register registro2 = new Register
            {
                car_id = 2,
                month = DateTime.Now.Month,
                day = DateTime.Now.Day,
                zone = "mexico",
                registerDate = DateTime.UtcNow,
                waves = 220,
                temperature = 78,
                data = "fail"
            };

            Register registro3 = new Register
            {
                car_id = 1,
                month = DateTime.Now.Month,
                day = DateTime.Now.Day,
                zone = "urgay",
                registerDate = DateTime.UtcNow,
                waves = 250,
                temperature = 35,
                data = "ok"
            };

            Register registro4 = new Register
            {
                car_id = 2,
                month = DateTime.Now.Month,
                day = DateTime.Now.Day,
                zone = "usa",
                registerDate = DateTime.UtcNow.AddSeconds(2),
                waves = 220,
                temperature = 14,
                data = "ok"
            };

            Register registro5 = new Register
            {
                car_id = 3,
                month = DateTime.Now.Month,
                day = DateTime.Now.Day,
                zone = "europe",
                registerDate = DateTime.UtcNow.AddSeconds(4),
                waves = 248,
                temperature = 74,
                data = "ok"
            };

            Register registro6 = new Register
            {
                car_id = 4,
                month = DateTime.Now.Month,
                day = DateTime.Now.Day,
                zone = "usa",
                registerDate = DateTime.UtcNow.AddSeconds(6),
                waves = 250,
                temperature = 63,
                data = "fail"
            };

            Register registro7 = new Register
            {
                car_id = 5,
                month = DateTime.Now.Month,
                day = DateTime.Now.Day,
                zone = "europe",
                registerDate = DateTime.UtcNow.AddSeconds(8),
                waves = 140,
                temperature = 25,
                data = "ok"
            };

            Register registro8 = new Register
            {
                car_id = 6,
                month = DateTime.Now.Month,
                day = DateTime.Now.Day,
                zone = "usa",
                registerDate = DateTime.UtcNow.AddSeconds(10),
                waves = 250,
                temperature = 43,
                data = "ok"
            };

            Register registro9 = new Register
            {
                car_id = 7,
                month = DateTime.Now.Month,
                day = DateTime.Now.Day,
                zone = "europe",
                registerDate = DateTime.UtcNow.AddDays(2),
                waves = 250,
                temperature = 14,
                data = "ok"
            };

            Register registro10 = new Register
            {
                car_id = 2,
                month = DateTime.Now.Month,
                day = DateTime.Now.Day,
                zone = "urgay",
                registerDate = DateTime.UtcNow.AddDays(3),
                waves = 220,
                temperature = 36,
                data = "ok"
            };

            Register registro11 = new Register
            {
                car_id = 1,
                month = DateTime.Now.Month,
                day = DateTime.Now.Day,
                zone = "usa",
                registerDate = DateTime.UtcNow.AddMinutes(45),
                waves = 250,
                temperature = 25,
                data = "fail"
            };

            Register registro12 = new Register
            {
                car_id = 123,
                month = DateTime.Now.Month,
                day = DateTime.Now.Day,
                zone = "usa",
                registerDate = DateTime.UtcNow.AddDays(8),
                waves = 140,
                temperature = 84,
                data = "ok"
            };

            Register registro13 = new Register
            {
                car_id = 2,
                month = DateTime.Now.Month,
                day = DateTime.Now.Day,
                zone = "usa",
                registerDate = DateTime.UtcNow.AddSeconds(85),
                waves = 248,
                temperature = 74,
                data = "ok"
            };

            Register registro14 = new Register
            {
                car_id = 5,
                month = DateTime.Now.Month,
                day = DateTime.Now.Day,
                zone = "europe",
                registerDate = DateTime.UtcNow.AddSeconds(746),
                waves = 250,
                temperature = 69,
                data = "ok"
            };

            Register registro15 = new Register
            {
                car_id = 6,
                month = DateTime.Now.Month,
                day = DateTime.Now.Day,
                zone = "europe",
                registerDate = DateTime.UtcNow.AddSeconds(173),
                waves = 250,
                temperature = 75,
                data = "ok"
            };

            Register registro16 = new Register
            {
                car_id = 1,
                month = DateTime.Now.Month,
                day = DateTime.Now.Day,
                zone = "usa",
                registerDate = DateTime.UtcNow.AddSeconds(453),
                waves = 250,
                temperature = 05,
                data = "ok"
            };

            Register registro17 = new Register
            {
                car_id = 3,
                month = DateTime.Now.Month,
                day = DateTime.Now.Day,
                zone = "europe",
                registerDate = DateTime.UtcNow.AddSeconds(5679),
                waves = 250,
                temperature = 46,
                data = "fail"
            };

            Register registro18 = new Register
            {
                car_id = 2,
                month = DateTime.Now.Month,
                day = DateTime.Now.Day,
                zone = "usa",
                registerDate = DateTime.UtcNow.AddSeconds(423),
                waves = 220,
                temperature = 48,
                data = "ok"
            };

            Register registro19 = new Register
            {
                car_id = 7,
                month = DateTime.Now.Month,
                day = DateTime.Now.Day,
                zone = "usa",
                registerDate = DateTime.UtcNow.AddSeconds(786),
                waves = 250,
                temperature = 47,
                data = "ok"
            };

            Register registro20 = new Register
            {
                car_id = 9,
                month = DateTime.Now.Month,
                day = DateTime.Now.Day,
                zone = "urgay",
                registerDate = DateTime.UtcNow.AddSeconds(142),
                waves = 140,
                temperature = 45,
                data = "ok"
            };

            Register registro21 = new Register
            {
                car_id = 7,
                month = DateTime.Now.Month,
                day = DateTime.Now.Day,
                zone = "usa",
                registerDate = DateTime.UtcNow.AddSeconds(75),
                waves = 250,
                temperature = 42,
                data = "fail"
            };

            Register registro22 = new Register
            {
                car_id = 5,
                month = DateTime.Now.Month,
                day = DateTime.Now.Day,
                zone = "europe",
                registerDate = DateTime.UtcNow.AddSeconds(453),
                waves = 250,
                temperature = 27,
                data = "ok"
            };

            Register registro23 = new Register
            {
                car_id = 4,
                month = DateTime.Now.Month,
                day = DateTime.Now.Day,
                zone = "usa",
                registerDate = DateTime.UtcNow.AddSeconds(79),
                waves = 140,
                temperature = 26,
                data = "ok"
            };

            Register registro24 = new Register
            {
                car_id = 2,
                month = DateTime.Now.Month,
                day = DateTime.Now.Day,
                zone = "europe",
                registerDate = DateTime.UtcNow.AddSeconds(452),
                waves = 248,
                temperature = 24,
                data = "ok"
            };

            Register registro25 = new Register
            {
                car_id = 5,
                month = DateTime.Now.Month,
                day = DateTime.Now.Day,
                zone = "urgay",
                registerDate = DateTime.UtcNow.AddSeconds(52),
                waves = 250,
                temperature = 22,
                data = "ok"
            };

                _mapper.Insert(registro1);
                _mapper.Insert(registro2);
                _mapper.Insert(registro3);
                _mapper.Insert(registro4);
                _mapper.Insert(registro5);
                _mapper.Insert(registro6);
                _mapper.Insert(registro7);
                _mapper.Insert(registro8);
                _mapper.Insert(registro9);
                _mapper.Insert(registro10);
                _mapper.Insert(registro11);
                _mapper.Insert(registro12);
                _mapper.Insert(registro13);
                _mapper.Insert(registro14);
                _mapper.Insert(registro15);
                _mapper.Insert(registro16);
                _mapper.Insert(registro17);
                _mapper.Insert(registro18);
                _mapper.Insert(registro19);
                _mapper.Insert(registro20);
                _mapper.Insert(registro21);
                _mapper.Insert(registro22);
                _mapper.Insert(registro23);
                _mapper.Insert(registro25);
                _mapper.Insert(registro24);
            }
            var listOfPosts = _mapper.Fetch<Register>();

            return Ok(listOfPosts.ToList());
        }


        [HttpPost]
        [Route("api/post")]
        public IHttpActionResult Post([FromBody] RegisterIn model)
        {
            try
            {


                Register registroNuevo = new Register
                {
                    car_id = model.car_id,
                    month = DateTime.Now.Month,
                    day = DateTime.Now.Day,
                    zone = "urgay",
                    registerDate = DateTime.UtcNow,
                    waves = model.waves,
                    temperature = model.temperature,
                    data = model.data
                };

                _mapper.Insert(registroNuevo);

                return Ok("Registro Ingresado");

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("api/get")]
        public IHttpActionResult Get()
        {
            var listOfPosts = _mapper.Fetch<Register>();

            return Ok(listOfPosts.ToList());
        }
    }
}