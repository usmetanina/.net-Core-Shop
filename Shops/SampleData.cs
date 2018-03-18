using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
using Shops.Models;

namespace Shops
{
    public class SampleData
    {
        public static void Initialize(string fileName)
        {
            if (!File.Exists(fileName))
            {
                File.Create(fileName);
            }

            Dictionary<int, Boot> boots = new Dictionary<int, Boot>
            {
                {
                    1,
                    new Boot
                    {
                        Name = "AirMax",
                        Company = "Nike",
                        Price = 2500,
                        Color = "Pink",
                        Id = 1
                    }
                },

                {
                    2,
                    new Boot
                    {
                        Name = "Jordan",
                        Company = "Adidas",
                        Price = 7500,
                        Color = "Black",
                        Id = 2
                    }
                },

                {
                    3,
                    new Boot
                    {
                        Name = "Westen",
                        Company = "Puma",
                        Price = 1500,
                        Color = "Red",
                        Id = 3
                    }
                },

                {
                    4,
                    new Boot
                    {
                        Name = "Asix",
                        Company = "Demix",
                        Price = 500,
                        Color = "White",
                        Id = 4
                    }
                }
            };

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(boots);
            File.WriteAllText(fileName, json);
        }
    }
}
