using ConsoleApp32;
namespace UserApp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            UserService service = new UserService();

            Console.WriteLine("cari istifadeciler ");
            User[] allUsers = service.GetAll();
            for (int i = 0; i < allUsers.Length; i++)
            {
                Console.WriteLine($"{allUsers[i].Id}: {allUsers[i].Name} - {allUsers[i].Email}");
            }

            Random rnd = new Random();
            int randomId = rnd.Next(1, 10);
            service.Create(new User(randomId, "akif", "akif42@gmail.com"));

            Console.WriteLine("\nYeni istifadeciler:");
            allUsers = service.GetAll();
            for (int i = 0; i < allUsers.Length; i++)

            {
                Console.WriteLine($"{allUsers[i].Id}: {allUsers[i].Name} - {allUsers[i].Email}");
            }

            Console.WriteLine("\nId = 3 olan istifadeci:");
            User u3 = service.GetById(3);
            if (u3 != null)
                Console.WriteLine($"{u3.Id}: {u3.Name} - {u3.Email}");

            service.Delete(2);

            Console.WriteLine("\nsilindikden sonra siyahi:");
            allUsers = service.GetAll();
            for (int i = 0; i < allUsers.Length; i++)
            {
                Console.WriteLine($"{allUsers[i].Id}: {allUsers[i].Name} - {allUsers[i].Email}");
            }
        }
    }
}