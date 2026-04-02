using System;
using System.Collections.Generic;
using System.Text;

namespace Deserializacja_do_Json
{
    public class Player
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int HealtPoints { get; set; }
        public List<Statistic> Statistics { get; set; }


    }
}
