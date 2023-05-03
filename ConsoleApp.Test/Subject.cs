using ConsoleApp.Test.Interfaces;

namespace ConsoleApp.Test
{
    public class Subject:IDataService
    {
        public string Name { get; set; }
        public int NumberOfCredits { get; set; }

        public string GetDataFromDatabase()
        {
            //throw new NotImplementedException();

            //SQL

            return "";
        }
    }
}
