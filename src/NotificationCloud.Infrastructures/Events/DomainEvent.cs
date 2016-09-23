using System;

namespace NotificationCloud.Infrastructures.Events
{
    public abstract class DomainEvent : IDomainEvent
    {
        protected DomainEvent(Guid aggregateId, int version)
        {
            Id = Guid.NewGuid();
            OccurredOn = DateTime.UtcNow;
            AggregateId = aggregateId;
            Version = version;
        }

        public Guid AggregateId { get; private set; }

        public Guid Id { get; private set; }

        public int Version { get; private set; }

        public DateTime OccurredOn { get; private set; }
    }
}