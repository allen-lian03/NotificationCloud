using System.Collections.Generic;

namespace NotificationCloud.Infrastructures.Buses
{
    public interface IBus
    {
        void Publish(object message);

        void Publish(IEnumerable<object> messages);
    }
}