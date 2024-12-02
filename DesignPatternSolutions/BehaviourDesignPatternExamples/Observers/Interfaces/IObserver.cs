namespace BehaviourDesignPatternExamples.Observers.Interfaces
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}