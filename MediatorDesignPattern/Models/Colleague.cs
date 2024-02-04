namespace MediatorDesignPattern.Models
{
    public abstract class Colleague
    {
        protected Mediator mediator;
        internal void SetMediator(Mediator mediator)
        {
            this.mediator = mediator;
        }
        public virtual void Send(string message)
        {
            this.mediator.Send(message, this);
        }
        public abstract void HandleNotification(string message);
    }

    public class Colleague1 : Colleague
    {
        public override void HandleNotification(string message)
        {
            Console.WriteLine($"Colleague1 receives notification message: {message}");
        }
    }

    public class Colleague2 : Colleague
    {
        public override void HandleNotification(string message)
        {
            Console.WriteLine($"Colleague2 receives notification message: {message}");
        }
    }
}
