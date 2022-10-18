using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    //Objective: Understand Overriding
    //expectation: need a parent class, child class and one function ChooseCareer()
    //Classes: Parent,Child
    //Relationship: Child:Parent
    //Properties: None
    //Functions: ChooseCareer() in both classes

    public class Parent
    {
        public virtual void ChooseCareer()
        {
            Console.WriteLine("Take admission for BE Computer Science");
        }
        public void NoNightsOuts()
        {
            Console.WriteLine("NightOuts not allowed");
        }
    }
    public class Child:Parent
    {
        public override void ChooseCareer()
        {
            Console.WriteLine("I will choose to become a standup comedian");

        }
        public void NoNightOuts()
        {
            Console.WriteLine("Will go for weekly night-outs!!");
        }
    }

}
