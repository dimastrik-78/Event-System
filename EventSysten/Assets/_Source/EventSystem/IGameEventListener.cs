using ResourceSystem;

namespace EventSystem
{
    public interface IGameEventListener
    {
        public void InvokeEvent();
        public void InvokeEvent(ResourceEnum type, int count);
    }
}