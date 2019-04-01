using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webServiceStrategy.Strategy_Map
{
    public class SMap
    {
        public int map_id { get; set; }
        public string SC_id { get; set; }
        public string map_name { get; set; }
        public byte[] bg_picture { get; set; }
        public string bg_picture_base64 { get; set; }
        public int default_map { get; set; }
        public string source_name { get; set; }
        public string user_created { get; set; }
        public DateTime date_created { get; set; }
        public string user_modify { get; set; }
        public DateTime date_modify { get; set; }
    }
}