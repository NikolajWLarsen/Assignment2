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
            student.StartDate = new DateTime(2020,8,31);
            student.EndDate = new DateTime(2024, 6, 1);
            var expected = Status.Active;
            
            //Act
            var status = student.getStatus();
            
            //Assert
            Assert.Equal(expected,status);
        }
        
        [Fact]
        public void Student_GetStatus_ReturnNew()
        {
            //Assign
            var student = new Student(1234);
            student.StartDate = new DateTime(2021,8,31);
            student.EndDate = new DateTime(2024, 6, 1);
            var expected = Status.New;
            
            //Act
            var status = student.getStatus();
            
            //Assert
            Assert.Equal(expected,status);
        }

        [Fact]
        public void Student_GetStatus_ReturnGraduated()
        {
            //Assign
            var student = new Student(1234);
            student.StartDate = new DateTime(2018,8,31);
            student.EndDate = new DateTime(2021, 6, 1);
            var expected = Status.Graduated;
            
            //Act
            var status = student.getStatus();
            
            //Assert
            Assert.Equal(expected,status);
        }

        [Fact]
        public void Student_ToString_ReturnString()
        {
            //Assign
            var student = new Student(1234);
            student.GivenName = "Benny";
            student.Surname = "Jensen";
            student.StartDate = new DateTime(2018,8,31);
            student.EndDate = new DateTime(2021, 6, 1);
            var expected = "Student#1234: Benny Jensen is Graduated";

            //Act
            var result = student.ToString();
            
            //Assert
            Assert.Equal(expected,result);
        }
    }
}
