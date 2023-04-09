using ResourceSystem;
using System.Collections.Generic;
using EventSystem;
using Until;

namespace UISwitcher.UIState
{
    class UIRemoveMenu : IUIState, IGameEventListener
    {
        private readonly List<ResourceController> _resources;
        private readonly OnSomeActionCallSO _onSomeActionCallSO;
        
        public UIRemoveMenu(List<ResourceController> resources, OnSomeActionCallSO onSomeActionCallSO)
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

        public void InvokeEvent(ResourceEnum type, int count)
        {
            ResourceController resourceController = MyExtensions.FindResource(_resources, type);
            
            resourceController.UpdateCountResource(-count);
        }

        public void InvokeEvent() { }
    }
}