using BehaviourDesignPatternExamples.Observers.Implementations;
using BehaviourDesignPatternExamples.Observers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviourDesignPatternExamples.Observer
{
    public class Client
    {

        public static void Run()
        {
            ISubject subects = new Subject();
            IObserver observer = new BehaviourDesignPatternExamples.Observers.Implementations.Observer();
            IObserver observer1 = new BehaviourDesignPatternExamples.Observers.Implementations.Observer();

            subects.Attach(observer);
            subects.Attach(observer1);
        }
    }
}
