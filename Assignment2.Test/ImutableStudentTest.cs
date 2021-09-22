using System;
using System.Runtime.CompilerServices;
using Xunit;

namespace Assignment2.Test
{
    public class ImmutableStudentTest
    {
        [Fact]
        public void ImmutableStudent_GetID_returnID()
        {
            // Assign
            var immutableS = new ImmutableStudent(1234);
            var expected = 1234;
            
            // Act
            var result = immutableS.id;
            
            // Assert
            Assert.Equal(expected,result);
        }

        [Fact]
        public void ImmutableStudent_GetStatus_ReturnActive()
        {
            // Assign
            var student = new Student(1234);
            student.StartDate = new DateTime(2020,8,31);
            student.EndDate = new DateTime(2024, 6, 1);
            var expected = Status.Active;
            
            // Act
            var immutableS = new ImmutableStudent(1234) with {StartDate = student.StartDate, EndDate = student.EndDate};
            var result = immutableS.getStatus();
            
            // Assert
            Assert.Equal(expected,result);
        }
        
        [Fact]
        public void ImmutableStudent_GetStatus_ReturnNew()
        {
            //Assign
            var student = new Student(1234);
            student.StartDate = new DateTime(2021,8,31);
            student.EndDate = new DateTime(2024, 6, 1);
            var expected = Status.New;
            
            //Act
            var immutableS = new ImmutableStudent(1234) with {StartDate = student.StartDate, EndDate = student.EndDate};
            var result = immutableS.getStatus();
            
            //Assert
            Assert.Equal(expected,result);
        }
        
        [Fact]
        public void ImmutableStudent_GetStatus_ReturnGraduated()
        {
            //Assign
            var student = new Student(1234);
            student.StartDate = new DateTime(2018,8,31);
            student.EndDate = new DateTime(2021, 6, 1);
            var expected = Status.Graduated;
            
            //Act
            var immutableS = new ImmutableStudent(1234) with {StartDate = student.StartDate, EndDate = student.EndDate};
            var result = immutableS.getStatus();
            
            //Assert
            Assert.Equal(expected,result);
        }
        
        [Fact]
        public void ImmutableStudent_ToString_ReturnString()
        {
            //Assign
            var student = new Student(1234);
            student.GivenName = "Benny";
            student.Surname = "Jensen";
            student.StartDate = new DateTime(2018,8,31);
            student.EndDate = new DateTime(2021, 6, 1);
            var expected = "Student#1234: Benny Jensen is Graduated";

            //Act
            var immutableS = new ImmutableStudent(1234) with {GivenName = student.GivenName,Surname = student.Surname, StartDate = student.StartDate, EndDate = student.EndDate};
            var result = student.ToString();
            
            //Assert
            Assert.Equal(expected,result);
        }
    }
}