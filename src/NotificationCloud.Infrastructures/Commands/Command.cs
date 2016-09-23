using System;

namespace NotificationCloud.Infrastructures.Commands
{
    public abstract class Command : ICommand
    {
        protected Command(Guid id, string userId)
        {
            Id = id;
            UserId = userId;
            OccurredOn = DateTime.UtcNow;
        }

        public Guid Id { get; private set; }

        public string UserId { get; private set; }

        public DateTime OccurredOn { get; private set; }
    }
}