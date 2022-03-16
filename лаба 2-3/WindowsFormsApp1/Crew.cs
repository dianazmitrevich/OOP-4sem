using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Crew
    {
        public string CrewName;
        public string CrewPosition;
        public int CrewAge;
        public string CrewWorkExperience;

        public Crew() { }

        public Crew(string name, string position, int age, string experience)
        {
            this.CrewName = name;
            this.CrewPosition = position;
            this.CrewAge = age;
            this.CrewWorkExperience = experience;
        }

        public override string ToString()
        {
            return $"{this.CrewPosition} {this.CrewName} (возраст {this.CrewAge}) со стажем {this.CrewWorkExperience}" + Environment.NewLine;
        }
    }
}
