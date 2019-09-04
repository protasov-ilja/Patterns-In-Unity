using Patterns.Singleton;
using System.Collections.Generic;
using UnityEngine.Events;

namespace Patterns.EventBus
{
	public sealed class EventBus : Singleton<EventBus>
	{
		private Dictionary<string, UnityEvent> _eventDictionary;

		public override void Awake()
		{
			base.Awake();

			Instance.Initialize();
		}

		private void Initialize()
		{
			if (Instance._eventDictionary == null)
			{
				Instance._eventDictionary = new Dictionary<string, UnityEvent>();
			}
		}

		public static void StartListening(string eventName, UnityAction listener)
		{
			if (Instance._eventDictionary.TryGetValue(eventName, out var thisEvent))
			{
				thisEvent.AddListener(listener);
			}
			else
			{
				thisEvent = new UnityEvent();
				thisEvent.AddListener(listener);
				Instance._eventDictionary.Add(eventName, thisEvent);
			}
		}

		public static void StopListening(string eventName, UnityAction listener)
		{
			if (Instance._eventDictionary.TryGetValue(eventName, out var thisEvent))
			{
				thisEvent.RemoveListener(listener);
			}
		}

		public static void TriggerEvent(string eventName)
		{
			if (Instance._eventDictionary.TryGetValue(eventName, out var thisEvent))
			{
				thisEvent.Invoke();
			}
		}
	}
}
