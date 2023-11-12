using System.Linq;

namespace Labb8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Employee empo1 = new Employee(1,"Zia", Gender.Male, 1);
            Employee empo2 = new Employee(2,"Sara ",Gender.Female, 42);
            Employee empo3 = new Employee(3, "Theo", Gender.Male, 142);
            Employee empo4 = new Employee(4, "Emil", Gender.Male, 127);
            Employee empo5 = new Employee(5, "Jonas", Gender.Male, 129);

            Stack<Employee> myEmpo = new Stack<Employee>(); // skappad en stack

            myEmpo.Push(empo1); // Created stack and using Push to implement them to the list
            myEmpo.Push(empo2);
            myEmpo.Push(empo3);
            myEmpo.Push(empo4);
            myEmpo.Push(empo5);

            Console.WriteLine("Alla objekt i stacken");

            foreach (var item in myEmpo) // Foreach to print out 
            {
                Console.WriteLine($"Id: {item.Id} Namn: {item.Name} Gender: {item.Gender} Salary: {item.Salary}");                                           
            }
            Console.WriteLine($"Antal objekt i Stack: " + myEmpo.Count);

            while(myEmpo.Count > 0) // adding object to the stack using pop
            {
                var ob = myEmpo.Pop();
                Console.WriteLine($"Id: {ob.Id} Namn: {ob.Name} Gender: {ob.Gender} Salary: {ob.Salary}");
            }

            Console.WriteLine($"Antal objekt i Stack efter pop: {myEmpo.Count}");

            myEmpo.Push(new Employee(1, "Reza ", Gender.Male, 20000));
            myEmpo.Push(new Employee(1, "jonathan ", Gender.Male, 20000));
            myEmpo.Push(new Employee(1, "markus ", Gender.Male, 20000));

         
            Console.WriteLine("Hämta två objekt med peek metod\n");

            var peek = myEmpo.Peek();
            Console.WriteLine($"ID: {peek.Id} Name: {peek.Name} Gander: {peek.Gender} Salary: {peek.Salary}");         
           
            var objekt3 = new Employee(3, "Nourozi ", Gender.Male, 142);
            bool count = myEmpo.Contains(objekt3);
            Console.WriteLine("Objekt 3 är " + count);            

            Console.ForegroundColor = ConsoleColor.Yellow;

            // Using List here to creating new object 
            List< Employee > myList = new List<Employee>();
            myList.Add(empo1);
            myList.Add(empo2);
            myList.Add(empo3);
            myList.Add(empo4);
            myList.Add(empo5);

            Employee empoCheck = new Employee(1, "Zia  ", Gender.Male, 1);

            if (myList.Contains(empoCheck))
            {
                Console.WriteLine("Employee2 object exist in the list");
            }
            else
            {
                Console.WriteLine("Employee2 object dosent exist in the list");
            }       

            Employee? fisrName = myList.Find(Employee => Employee.Gender == Gender.Male);

            if(fisrName == null)
            {
                Console.WriteLine("Det finns ingen Male");
            }
            else
            {
                Console.WriteLine("Det finns Male");
            }

           var find = myList.FindAll(Employee => Employee.Gender == Gender.Male);
            foreach(var item in find)
            {
                Console.WriteLine(item.Name);
            }          
        }
    }
}