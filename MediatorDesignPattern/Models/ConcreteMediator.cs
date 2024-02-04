namespace MediatorDesignPattern.Models
{
    public class ConcreteMediator : Mediator
    {

        private List<Colleague> colleagues = new List<Colleague>();
        public T CreateColleague<T>() where T : Colleague, new()
        {
            var c = new T();
            c.SetMediator(this);
            this.colleagues.Add(c);
            return c;
        }
        public override void Send(string message, Colleague colleague)
        {
            this.colleagues.Where(c => c != colleague).ToList().ForEach(c => c.HandleNotification(message));
        }
    }
}
