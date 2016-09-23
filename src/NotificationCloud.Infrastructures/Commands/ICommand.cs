using System;

namespace NotificationCloud.Infrastructures.Commands
{
    public interface ICommand
    {
        Guid Id { get; } 

        string UserId { get; }

        DateTime OccurredOn { get; }
    }
}