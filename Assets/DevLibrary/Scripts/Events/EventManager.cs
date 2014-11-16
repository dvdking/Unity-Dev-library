using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevLibrary.Events
{
    public class EventManager
    {
        private readonly Dictionary<Type, EventData> _events;

        public EventManager()
        {
            _events = new Dictionary<Type, EventData>();
        }

        public void Send<T>() where T:AppEvent
        {
            var eventData = GetEventData<T>();

            foreach (var eventSubscriber in eventData.Subscribers)
            {
                eventSubscriber.Receive(eventData.Event);
            }
        }

        public void Subscribe<T>(IEventSubscriber<T> subscriber) where T : AppEvent
        {
            var eventData = GetEventData<T>();
            eventData.Subscribers.Add(subscriber);
        }

        public void Unsubscribe<T>(IEventSubscriber<T> subscriber) where T : AppEvent
        {
            var eventData = GetEventData<T>();
            eventData.Subscribers.Remove(subscriber);
        }

        public T Get<T>() where T : AppEvent
        {
            var data = GetEventData<T>();

            if (data != null)
            {
                return data.Event;
            }

            return null;
        }

        private EventData<T> GetEventData<T>() where T: AppEvent
        {
            EventData data;

            _events.TryGetValue(typeof(T), out data);

            if (data == null)
            {
                data = Activator.CreateInstance(typeof(EventData<T>)) as EventData;
            }

            return data as EventData<T>;
        }

        private abstract class EventData{}
        private class EventData<T>: EventData where T:AppEvent
        {
            public readonly List<IEventSubscriber<T>> Subscribers = new List<IEventSubscriber<T>>();
            public readonly T Event = Activator.CreateInstance<T>();
        }
    }
}
