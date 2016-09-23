namespace NotificationCloud.Infrastructures.Events
{
    public interface IEventHandler<TEvent> where TEvent : IDomainEvent
    {
        void Execute(TEvent @event);
    }
}