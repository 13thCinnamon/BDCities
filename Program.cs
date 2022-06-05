using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace CitiesDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "json1.json");
            var json = File.ReadAllText(path);
            var jsonObjs = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<City>>(json);

            using (CitiesContext db = new CitiesContext())
            {
                db.Cities.AddRange(jsonObjs);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");
            }
        }
    }
}
