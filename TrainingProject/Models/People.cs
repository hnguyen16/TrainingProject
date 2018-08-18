using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.Models
{
    class People
    {
        public string name { get; set; }
        public int age { get; set; }
        public string spouse { get; set; }
        public List<int> numList { get; }

        public People(string name, int age, string spouse, List<int> numList)
        {
            this.name = name;
            this.age = age;
            this.spouse = spouse;
            this.numList = numList;
        }
    }
}
