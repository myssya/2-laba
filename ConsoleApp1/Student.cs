using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        private Exam[] _infoexam;

        private Person DataStudent { get; set; }
        private Education FormOfEducation { get; set; }
        private int groupnumber { get; set; }
        private Exam[] infoexam { get; set; }
        private Student(Person DataStudent, Education FormOfEducation, int groupnumber, Exam[] infoeaxam)
        {
            this.DataStudent = DataStudent;
            this.FormOfEducation = FormOfEducation;
            this.groupnumber = groupnumber;
            this.infoexam = infoeaxam;
        }
        private Student()
        {
            this.DataStudent = new Person();
            this.FormOfEducation = Education.Bachelor;
            this.groupnumber = 21;
            this.infoexam = new Exam[3];
        }
        private Person _datastudent
        {
            get { return _datastudent; }
            set { _datastudent = value; }
        }
        private Education _formOfEducation
        {
            get { return _formOfEducation; }
            set { _formOfEducation = value; }
        }
        private int _groupnumber
        {
            get { return _groupnumber; }
            set { _groupnumber = value; }
        }
        private double mark
        {
            get { return _infoexam.Length > 0 ? _infoexam.Average(e => e.mark) : 0; }
        }
        private void AddExams(params Exam[] newExam) 
        {
            //infoexam.Length
         //   this._infoexam.AddExams(_infoexam);
        }
    }
}
