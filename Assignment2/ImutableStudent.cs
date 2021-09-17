using System

namespace Assignment2
{
    public record ImutableStudent
    {
        public int id { get; init; }
        public string GivenName { get; init; }
        public string Surname { get; init; }
        public Status status { get => getStatus(); }
        DateTime StartDate { get; init; }
        DateTime EndDate { get; init; }
        public DateTime GraduationDate { get; init; }
        
        public ImutableStudent(int Id)
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
}