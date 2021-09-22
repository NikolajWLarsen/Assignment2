using System;

namespace Assignment2
{
    public record ImmutableStudent
    {
        public int id { get; init; }
        public string GivenName { get; init; }
        public string Surname { get; init; }
        public Status status { get => getStatus(); }
        public DateTime StartDate { get; init; }
        public DateTime EndDate { get; init; }
        public DateTime GraduationDate { get; init; }
        
        public ImmutableStudent(int Id)
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
        
        public override string ToString()
        {
            return "Student#" + id + ": " + GivenName + " " + Surname + " is " + status;
        }

    }
    
}