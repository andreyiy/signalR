using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessLayer.Models
{
    public class StudInfoViewModel
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int TeacherID { get; set; }
        public double GradeAverage { get; set; }
        public string StatusId { get; set; }

        public StudInfoViewModel()
        {

        }
        public StudInfoViewModel(int StudentID, string FirstName, string LastName, string Email, string PhoneNumber)
        {
            this.StudentID = StudentID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
        }
        public StudInfoViewModel(int StudentID, string FirstName, string LastName, string Email, string PhoneNumber, int TeacherID)
        {
            this.StudentID = StudentID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.TeacherID = TeacherID;
        }
    }
}