using Newtonsoft.Json;
using Shops.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Shops
{
    public class Storage
    {
        public static Dictionary<int, Boot> GetBoots(string fileName)
        {
            string json = File.ReadAllText(fileName);
            var boots = JsonConvert.DeserializeObject<Dictionary<int, Boot>>(json);
            return boots;
        }

        public static Boot GetBootById(string fileName, int id)
        {
            string json = File.ReadAllText(fileName);
            var boots = JsonConvert.DeserializeObject<Dictionary<int, Boot>>(json);
            var boot = boots[id];
            return boot;
        }
    }
}
