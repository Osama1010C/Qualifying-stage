using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grouping
{
    internal class Stage
    {
        private List<string> UsersNames = new List<string>();

        private int usersNum;
        public int UsersNum
        {
            get
            {
                return this.usersNum;
            }
            set
            {
                if(value <= 0)
                {
                    this.usersNum = 0;
                }
                else if(value % 2 != 0)
                {
                    this.usersNum = value + 1;
                    UsersNames.Add("NO ONE");
                }
                else
                {
                    this.usersNum = value;
                }
            }
        }

        
        public Stage(int usernum)
        {
            UsersNum = usernum;
        }
        public Stage() : this(0)
        {

        }
        
        private void AddUsers(string[] users)
        {
            foreach(string user in users)
            {
                UsersNames.Add(user);
            }
        }

        private string[] GenerateStage(string[] users)
        {
            string[] result = new string[UsersNum];
            AddUsers(users);
            Random random = new Random();
            int iterator = 0;
            while(UsersNames.Count() != 0)
            {
                int randomNum = random.Next(0, UsersNames.Count());
                result[iterator] = UsersNames[randomNum];
                UsersNames.RemoveAt(randomNum);
                iterator++;
            }
            return result;
        }

        public void DisplayMatchesCenimatic(string[] users)
        {
            string[] result = GenerateStage(users);
            
            for(int i = 0; i < UsersNum-1; i+=2)
            {
                Console.Write(result[i]);
                Thread.Sleep(1000);
                Console.Write(" VS ");
                Thread.Sleep(1000);
                Console.WriteLine(result[i+1] + "\n");
                Thread.Sleep(1500);
            }           
        }
        public void DisplayMatchesQuickly(string[] users)
        {
            string[] result = GenerateStage(users);

            for (int i = 0; i < UsersNum - 1; i += 2)
            {
                Console.Write(result[i]);
                
                Console.Write(" VS ");
                
                Console.WriteLine(result[i + 1] + "\n");
                Thread.Sleep(500);
            }
        }
    }
}
