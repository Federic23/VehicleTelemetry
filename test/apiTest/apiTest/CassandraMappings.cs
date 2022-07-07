using apiTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api
{
    public class CassandraMappings : Cassandra.Mapping.Mappings
    {
        public CassandraMappings()
        {
            For<Test>()
                .TableName("users")
                .PartitionKey(u => u.id)
                .Column(x => x.numero)
                .Column(x => x.id);

            For<Register>()
                .TableName("registers")
                .PartitionKey(u => u.zone)
                .PartitionKey(u => u.month)
                .PartitionKey(u => u.day)
                .ClusteringKey(u => u.registerDate)
                .ClusteringKey(u => u.car_id)
                .Column(x => x.car_id)
                .Column(x => x.zone)
                .Column(x => x.data)
                .Column(x => x.month)
                .Column(x => x.day)
                .Column(x => x.temperature)
                .Column(x => x.registerDate)
                .Column(x => x.waves);
              
        }
    }
}
