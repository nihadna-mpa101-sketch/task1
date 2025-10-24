namespace ConsoleApp32
{
    public class User
    {
        public int Id { get; }
        public string Name { get; set; }
        public string Email { get; set; }

        public User(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
    }

    public class UserService
    {
        private User[] users;

        public UserService()
        {
            users = new User[]
            {
                new User(1, "nihad", "nihad12@gmail.com"),
                new User(2, "eli", "eli123@gmail.com"),
                new User(3, "seyid", "seyid42@gmail.com"),
                new User(4, "ferid", "ferid02@gmail.com"),
                new User(5, "saleh", "saleh52@gmail.com")
            };
        }

        public void Create(User user)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].Id == user.Id)
                {
                    Console.WriteLine($" {user.Id} olan istifadeci artiq var");
                    return;
                }
            }

            User[] newUsers = new User[users.Length + 1];
            int k = 0;
            for (int i = 0; i < users.Length; i++)
            {
                newUsers[k] = users[i];
                k++;
            }
            newUsers[users.Length] = user;
            users = newUsers;
            for(int i=0;i<users.Length; i++)
            {
                Console.WriteLine(newUsers[i]);
            }
           
        }

        public User GetById(int id)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].Id == id)
                    return users[i];
            }
            return null;
        }

        public User[] GetAll()
        {
            return users;
        }

        public void Delete(int id)
        {
            int index = -1;
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].Id == id)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                Console.WriteLine($" {id} istifadeci tapilmadi");
                return;
            }

            User[] newUsers = new User[users.Length - 1];
            int newIndex = 0;
            for (int i = 0; i < users.Length; i++)
            {
                if (i == index) continue;
                newUsers[newIndex++] = users[i];
            }

            users = newUsers;
            Console.WriteLine($"Id {id} olan istifadeci silindi");
        }
    }

}
