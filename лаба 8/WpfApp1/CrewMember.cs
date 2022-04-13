using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class CrewMember
    {
        public int ID { get; set; }
        public string NameSurname { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }
        public int Experience { get; set; }
        public int PlaneID { get; set; }

        public CrewMember(int id, string nameSurname, string position, int age, int experience, int planeID)
        {
            this.ID = id;
            this.NameSurname = nameSurname;
            this.Position = position;
            this.Age = age;
            this.Experience = experience;
            this.PlaneID = planeID;
        }

        public CrewMember() { }
    }
}
