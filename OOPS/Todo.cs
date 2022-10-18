using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Todo
    {
        //name, startdate, end date, iscompleted =>Properties
        public string Name { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsCompleted { get; set; }
        //function: create(), edit(), delete(), view()

        private Todo[] _todos = new Todo[10];
        
        public void View()
        {
            foreach (var singleTodo in _todos)

            {
                if (singleTodo != null)
                {
                    Console.WriteLine($"Name: {singleTodo.Name} started on{singleTodo.StartDate}| " +
                        $"ends on {singleTodo.EndDate} |" + $"Is completed {IsCompleted}");
                }
              
            }    
        }
        public void View(string pName) //overloading function with 2 parameters
        {
            foreach (var singleTodo in _todos)
            {
               
                if (singleTodo.Name == pName)
                {
                    Console.WriteLine($"Name: {singleTodo.Name}| " + $"started on {singleTodo.StartDate}| " +
                        $"ends on {singleTodo.EndDate} |" + $"Is completed {singleTodo.IsCompleted}");

                    break;
                }
                
            }
        }
        public void create(int pPosition)
        {
            if (pPosition > 9)
            {
                throw new Exception("Please enter a number between 0-9");
            }
            _todos[pPosition] = new Todo() { Name = this.Name, StartDate = this.StartDate, EndDate = this.EndDate, 
                IsCompleted = this.IsCompleted };

            Console.WriteLine("ToDo Created Successfully");


        }
        public void edit()
        {

        }
        public void delete()
        {

        }

    }
}
