CREATE KEYSPACE vehicle_telemetry_key WITH REPLICATION = {'class' : 'SimpleStrategy', 'replication_factor' : 1};



docker run --rm --network cassandra -v "$(pwd)/data.cql:/scripts/data.cql" -e CQLSH_HOST=cassandra -e CQLSH_PORT=9042 -e CQLVERSION=3.4.5 nuvo/docker-cqlsh