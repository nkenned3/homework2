using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework2.Models;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<Models.User>();

            users.Add(new User { Name = "Dave", Password = "hello" });
            users.Add(new User { Name = "Steve", Password = "steve" });
            users.Add(new User { Name = "Lisa", Password = "hello" });
            //step 1
            var hellos = users.Where(t => t.Password == "hello");
            foreach(var h in hellos)
            {
                Console.WriteLine(h.Password);
            }

            //step 2
            users.RemoveAll(t => t.Password.ToString().ToLower() == t.Name.ToString().ToLower());
            Display(users);

            //step 3
            users.Remove(users.FirstOrDefault(t => t.Password.ToLower() == "hello"));

            //step 4
            Display(users);


            Console.ReadLine();

        }
        public static void Display(IEnumerable<object> users)
        {
            Console.WriteLine("-----------------------");
            foreach (var u in users)
            {
                Console.WriteLine(u);
            }
        }

    }
}
