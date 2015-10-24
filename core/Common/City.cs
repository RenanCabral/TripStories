using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common
{
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
        ICollection<Photo> Photos { get; set; }
    }
}
