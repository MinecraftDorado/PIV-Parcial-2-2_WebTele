using System.Xml.Linq;

namespace WebTele.Models
{
    public class Program
    {

        public Program(string name, string desc, string img)
        {
            this.name = name;
            this.description = desc;
            this.img = img;
        }

        public string name { get; set; }
        public string description { get; set; }
        public string img { get; set; }

    }
}
