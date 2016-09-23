namespace NotificationCloud.Infrastructures.Commands
{
    public interface ICommandHandler<TCommand> where TCommand : ICommand
    {
        void Execute(TCommand command);
    }
}