using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
   //Objective: Understand overriding
   //expectation: Need a parent class, child class and one function called ChooseCareer()
   //Classes: Parent, Child
   //Relationship: Child : Parent
   //Properties: None
   //Functions: ChooseCareer() in both the classes.

    public class Parent
    {
        public virtual void ChooseCareer()
        {
            Console.WriteLine("Take admission for BE Computer Science");
        }

        public void NoNightOuts()
        {
            Console.WriteLine("Outing is not allowed");
        }
    }
    public class Child: Parent
    {
        public override void ChooseCareer()
        {
            //base.ChooseCareer();
            Console.WriteLine("I will choose to become a standup comedian");
        }
        public void NoNightOuts()
        {
            Console.WriteLine("I will go for outing");
        }
    }
}
