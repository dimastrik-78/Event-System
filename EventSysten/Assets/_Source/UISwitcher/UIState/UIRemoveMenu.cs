using System;
using ResourceSystem;
using System.Collections.Generic;
using Signals;
using Until;

namespace UISwitcher.UIState
{
    class UIRemoveMenu : IUIState
    {
        private readonly List<ResourceController> _resources;
        
        public UIRemoveMenu(List<ResourceController> resources)
        {
            _resources = resources;
        }

        private void RemoveResource(ResourceEnum type, int count)
        {
            ResourceController resourceController = MyExtensions.FindResource(_resources, type);
            
            resourceController.UpdateCountResource(-count);
        }

        public void Enter()
        {
            Until.Signals.Get<RemoveResourceSignal>().AddListener(RemoveResource);
        }

        public void Exit()
        {
            Until.Signals.Get<RemoveResourceSignal>().RemoveListener(RemoveResource);
        }
    }
}
