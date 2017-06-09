using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airtraffic_Simulator
{
    public class Problem
    {
        public int nmbProblems = 0;
        public int Id { get; private set; }
        public string Type { get; private set; }
        public TimeSpan Duration { get; private set; }
        public Problem(string type, TimeSpan duration)
        {
            nmbProblems += 1;
            this.Id = nmbProblems ;
            this.Type = type;
            this.Duration = duration;
            
        }
    }
}
