using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationProject {
   
    public class Major {
        // this is static property
        private static int NextId { get; set; } = 1;

        public int Id { get; set; }
        public string Description { get; set; }   
        public int MinSAT { get; set; }

        //this is the constructor
        public Major(string description, int minSAT) {
            Id = NextId++;  //or Id = NextId; NextId++;
            Description = description;
            MinSAT = minSAT;             

        }
      

    }
}
