using Realms;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopcornHelper.Models
{
    public class Order : RealmObject
    {
        [PrimaryKey]
        [MapTo("_id")]
        public int Id { get; set; }

        [MapTo("name")]
        public string Name { get; set; }

        [MapTo("popcorn")]
        public string Popcorn { get; set; }

        [MapTo("quantity")]
        public int Quantity { get; set; }

        [MapTo("status")]
        public string Status { get; set; }
    }
}
