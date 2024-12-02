namespace BehaviourDesignPatternExamples.Observers.Interfaces
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void UnAttach(IObserver observer);
        void Notify();
        string Message { get; set; }
    }
}
