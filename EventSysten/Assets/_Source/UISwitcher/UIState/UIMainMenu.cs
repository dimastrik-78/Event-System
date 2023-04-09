using ResourceSystem;
using System.Collections.Generic;
using EventSystem;

namespace UISwitcher.UIState
{
    class UIMainMenu : IUIState, IGameEventListener
    {
        private readonly List<ResourceController> _resources;
        private readonly OnSomeActionCallSO _onSomeActionCallSO;

        public UIMainMenu(List<ResourceController> resources, OnSomeActionCallSO onSomeActionCallSO)
        {
            _resources = resources;
            _onSomeActionCallSO = onSomeActionCallSO;
        }

        public void Enter()
        {
            _onSomeActionCallSO.RegisterListener(this);
        }

        public void Exit()
        {
            _onSomeActionCallSO.RemoveListener(this);
        }

        public void InvokeEvent()
        {
            foreach (var resource in _resources)
            {
                resource.Clear();
            }
        }

        public void InvokeEvent(ResourceEnum type, int count) { }
    }
}