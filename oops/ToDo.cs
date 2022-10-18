using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class ToDo
    {
        public string Name { get; set;}
        public DateTime StartDate { get; set;}
        public DateTime EndDate { get; set;}
        public bool IsCompleted { get; set;}
        private ToDo[] todo = new ToDo[10];
        
        public void ViewTodos()
        {
            foreach (var  singleTodo in todo)
            {
                if (singleTodo != null)
                {
                    Console.WriteLine("Name: " + singleTodo.Name + " | " + "Started On: " + singleTodo.EndDate + " | "
                + "Is completed: " + singleTodo.IsCompleted);
                }
            }
        }
        public void ViewTodos(string pName)
        {
            foreach (var singleTodo in todo)
            {
                if(singleTodo.Name == pName)
                {
                    Console.WriteLine("Name: " + singleTodo.Name + " | " + "Started On: " + singleTodo.EndDate + " | " 
                    + "Is completed: " + singleTodo.IsCompleted);
                    break;
                }
            }
        }
        public void Create(int pPosition)
        {
            if (pPosition > 9)
            {
                throw new Exception("Please enter a value between 0-9");
            }
            todo[pPosition] = new ToDo()
            {
                Name = this.Name,
                StartDate = this.StartDate,
                EndDate = this.EndDate,
                IsCompleted = this.IsCompleted
            };
            Console.WriteLine("ToDo created successfully");
        }
        public void Edit()
        {

        }
        public void Delete()
        {

        }
    }
}
