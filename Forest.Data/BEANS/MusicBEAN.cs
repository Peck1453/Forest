using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest.Data.BEANS
{
       public class MusicBEAN
    {

        public int Id { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Image_Name { get; set; }
        public Nullable<int> Num_Tracks { get; set; }
        public double price { get; set; }
        public int Stock_Count { get; set; }
        public System.DateTime Released { get; set; }
        public MusicBEAN() { }


    }
}
