using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Self
{
    class UProgram
    {
        private string programName;
        private List<Degree> degrees = new List<Degree>();

        public string ProgramName { get => programName; set => programName = value; }
        internal List<Degree> Degrees { get => degrees; set => degrees = value; }

        public UProgram(string programName)
        {
            this.ProgramName = programName;
        }
        public UProgram(string programName, List<Degree> degrees)
        {
            this.ProgramName = programName;
            this.Degrees = degrees;
        }

        public void AddDegree(Degree degree)
        {
            Degrees.Add(degree);
        }
    }
}
