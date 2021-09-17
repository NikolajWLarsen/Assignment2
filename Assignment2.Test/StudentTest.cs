using System;
using Xunit;

namespace Assignment2.Test
{
    public class StudentTest
    {
        [Fact]
        public void Student_GetStatus_ReturnActive()
        {
            //Assign
            var student = new Student(1234);
            student.StartDate = new DateTime(2021,8,31);
            
            //Act
            var status = student.getStatus();

        }
    }
}
