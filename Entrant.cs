using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trpo_task_25_11
{
    public class Entrant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Math { get; set; }
        public int RusLang { get; set; }
        public int ForeignLang { get; set; }
        public int Physics { get; set; }
        public int PE { get; set; }
        public int Biology { get; set; }
        public int Informatics { get; set; }
        public int Chemistry { get; set; }

        public History History { get; set; }
    }
}
