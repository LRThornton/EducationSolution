using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationProject {

    public class Student {

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int SAT { get; set; }
        public decimal GPA { get; set; }
        public Major Major { get; set; } // the second "Major" could be fred (public major Fred)

        //method
        public Major GetMajorByDescription(string description, 
                                        List<Major> majors) {
            foreach(Major m in majors) {
                if(description == m.Description) {
                    return m;
                }
            }
            return null;
        }

        //constructor

        public Student(string firstname, string lastname, int sat, decimal gpa) {
            Firstname = firstname;
            Lastname = lastname;
            SAT = sat;
            GPA = gpa;
            Major = null;

        }


    }
}
