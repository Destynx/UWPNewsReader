using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NewsReader.Model
{
    public class RootObject
    {
        public List<Article> Results { get; set; }
        public int NextId { get; set; }
    }
}
