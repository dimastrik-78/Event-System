using System.Collections.Generic;
using ResourceSystem;
using UnityEngine;

namespace EventSystem
{
    [CreateAssetMenu(fileName = "NewOnSomeActionCallSO", menuName = "SO/New Some Action Call SO")]
    public class OnSomeActionCallSO : ScriptableObject
    {
        private readonly List<IGameEventListener> _listeners = new();

        public void RegisterListener(IGameEventListener listener) => _listeners.Add(listener);
        public void RemoveListener(IGameEventListener listener) => _listeners.Remove(listener);

        public void InvokeListener()
        {
            foreach (IGameEventListener listener in _listeners)
            {
                listener.InvokeEvent();
            }
        }
        
        public void InvokeListener(ResourceEnum type, int count)
        {
            foreach (IGameEventListener listener in _listeners)
            {
                listener.InvokeEvent(type, count);
            }
        }
    }
}
