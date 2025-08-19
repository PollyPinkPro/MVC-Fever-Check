using System.ComponentModel.DataAnnotations;

namespace MVCAssignment_1___2.Models
{
    public class Student
    {
        public int SId { get; set; }
        public string Name { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public Student()
        {

        }
         public Student(int sid, string name, string phone, string email)
         {
            SId = sid;
            Name = name;
            Phone = phone;
            Email = email;

         }


    }
}
