using BehaviourDesignPatternExamples.Observers.Interfaces;


namespace BehaviourDesignPatternExamples.Observers.Implementations
{
    public class Observer : IObserver
    {
        public void Update(ISubject subject)
        {
            Console.WriteLine(subject.Message);  
        }
    }
}
