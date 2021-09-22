using System;

namespace Assignment2
{
    public class Student
    {
        public int id { get; set; }
        public string GivenName { get; set; }
        public string Surname { get; set; }
        public Status status { get => getStatus(); }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime GraduationDate { get; set; }
        
        public Student(int Id)
        {
            this.id = Id;
        }
        public Status getStatus()
        {
            
            var time = DateTime.Now;
            if ((time - StartDate).TotalDays < 121)
            {
                return Status.New;
            }
            else if ((time - StartDate).TotalDays > 121 && time < EndDate)
            {
                return Status.Active;
            }
            else
            {
                return Status.Graduated;}
        }

        public string ToString()
        {
            return "Student#" + id + ": " + GivenName + " " + Surname + " is " + status;
        }
        
        

    }
    
    public enum Status
    {
        New, Active, Dropout, Graduated
    }

    
}