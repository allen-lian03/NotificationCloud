using System;

namespace NotificationCloud.Infrastructures.Events
{
    public interface IDomainEvent
    {
        Guid Id { get; } 

        Guid AggregateId { get; }

        int Version { get; }

        DateTime OccurredOn { get; }
    }
}