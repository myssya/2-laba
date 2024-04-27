using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Exam : Object
    {
        public string objecti { get; set; }
        public int mark { get; set; }
        public System.DateTime DateOfExams { get; set; }
        public Exam(string objecti, int mark, System.DateTime DateOfExams)
        {
            this.objecti = objecti;
            this.mark = mark;
            this.DateOfExams = DateOfExams;
        }
        public Exam()
        {
            this.objecti = "english";
            this.mark = 5;
            this.DateOfExams = new DateTime(2015, 04, 18);
        }
        public string TofullString()
        {
            return mark.ToString() + DateOfExams.ToString();
        }
    }
}
