using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TaskBase.TaskBase
{
    class Program
    {

        public void menue()
        {
            
            Console.WriteLine("To add new task press 1 ");
            Console.WriteLine("To exit and view all tasks press 2 ");

        }
        static void Main(string[] args)
        {
            List<Tasks> ListOfTasks = new List<Tasks>();
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< Welcome in  task base >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> ");
            List<string> tasks = new List<string>();
            int number;
            Program program = new Program();
            program.menue();

            string ch = Console.ReadLine();
            int.TryParse(ch, out number);
            while (true)
            {


                if (number == 1 || number == 2)
                {
                    int.TryParse(ch, out number);

                    if (number == 1)
                    {
                        Tasks tasks1 = new Tasks();
                        Console.WriteLine($"Enter the task name");
                        string taskName = Console.ReadLine();
                        tasks1.TaskName = taskName;
                        //tasks.Add(taskName);
                        string tasktDate = DateTime.Now.ToString();
                        tasks1.TaskDate = tasktDate;
                        ListOfTasks.Add(tasks1);
                        program.menue();
                        ch = Console.ReadLine();
                        int.TryParse(ch, out number);
                    }

                    if (number == 2)
                    {
                        foreach (Tasks t in ListOfTasks)
                        {
                            Console.WriteLine("Task Name is: {0}, Task Date is : {1}", t.TaskName, t.TaskDate);
                        }

                        Console.WriteLine();
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter 1 or 2 ");
                    program.menue();
                    ch = Console.ReadLine();
                    int.TryParse(ch, out number);
                }

            }//while
        
            

           

        }//main

    }
    

}

    
   
