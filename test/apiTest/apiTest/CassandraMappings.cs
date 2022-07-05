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
            For<Test>().TableName("users")
                .PartitionKey(u => u.id)
                .Column(x => x.numero)
                .Column(x => x.id);
        }
    }
}
