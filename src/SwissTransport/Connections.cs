using System.Collections.Generic;
using Newtonsoft.Json;

namespace SwissTransport
{
    public class Connections
    {
        [JsonProperty("connections")]
        public List<Connection> ConnectionList { get; set; } 
    }

    public class Connection
    {
        [JsonProperty("from")]
        public ConnectionPoint From  { get; set; }

        [JsonProperty("to")]
        public ConnectionPoint To { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }
    }

    public class ConnectionPoint
    {
        [JsonProperty("station")]
        public Station Station { get; set; }

        [JsonProperty("arrival")]
        public string Arrival { get; set; }

        [JsonProperty("arrivaltimestamp")]
        public string ArrivalTimestamp { get; set; }

        [JsonProperty("departure")]
        public string Departure { get; set; }

        [JsonProperty("departuretimestamp")]
        public string DepartureTimestamp { get; set; }

        [JsonProperty("delay")]
        public int? Delay { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("realtimeavailability")]
        public string RealtimeAvailability { get; set; }
    }
}