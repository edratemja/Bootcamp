using ConsoleApp.Test.Interfaces;

namespace ConsoleApp.Test
{
    public class Student : IDataService //BaseClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetDataFromDatabase()
        {
            //throw new NotImplementedException();

            //MYSQL
            
            return "";
        }

        public string GetFullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }
        
        
        

        //Identifier
        //public Guid Id { get; set; }



        //public DateTime DateOfBirth { get; set; }
        //public string Address { get; set; }
        //public string PhoneNumber { get; set; }
        //public string Email { get; set; }


        //public Student()
        //{
        //}

        //public Student(string firstName)
        //{
        //    FirstName = firstName;
        //}

        //public Student(string firstName, string lastName)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //}


        //public string GetFullName()
        //{
        //    return $"{FirstName} {LastName}";
        //}

        //public int GetAge()
        //{
        //    var age = DateTime.Now.Year - DateOfBirth.Year;
        //    return age;
        //}

    }
}
