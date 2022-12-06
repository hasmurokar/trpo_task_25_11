using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trpo_task_25_11
{
    public class History
    {
        public int Id { get; set; }
        public double AvgNote { get; set; }

        public int EntrantId { get; set; }
        public Entrant Entrant { get; set; }
    }
}
