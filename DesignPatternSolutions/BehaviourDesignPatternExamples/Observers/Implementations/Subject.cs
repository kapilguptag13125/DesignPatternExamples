using BehaviourDesignPatternExamples.Observers.Interfaces;

namespace BehaviourDesignPatternExamples.Observers.Implementations
{
    public class Subject : ISubject
    {
        private readonly List<IObserver> observers = new List<IObserver>();

        public Subject()
        {
            SomeBusinessLogic();
        }
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public string Message { get; set; }

        public void Notify()
        {
            foreach(var  observer in observers)
            {
                observer.Update(this);
            }
        }

        public void UnAttach(IObserver observer)
        {
            observers.Remove(observer);
        }

        private async void SomeBusinessLogic()
        {
            while (true)
            {
                this.Message = $"New Message: {System.DateTime.Now}";
                this.Notify();
                await Task.Delay(3000);
            }
        }

    }
}
