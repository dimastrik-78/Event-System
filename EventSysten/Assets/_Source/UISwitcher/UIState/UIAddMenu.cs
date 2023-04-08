using ResourceSystem;
using System.Collections.Generic;
using Signals;
using Until;

namespace UISwitcher.UIState
{
    class UIAddMenu : IUIState
    {
        private readonly List<ResourceController> _resources;

        public UIAddMenu(List<ResourceController> resources)
        {
            _resources = resources;
        }

        private void AddResource(ResourceEnum type, int count)
        {
            ResourceController resourceView = MyExtensions.FindResource(_resources, type);
            
            resourceView.UpdateCountResource(count);
        }

        public void Enter()
        {
            Until.Signals.Get<AddResourceSignal>().AddListener(AddResource);
        }

        public void Exit()
        {
            Until.Signals.Get<AddResourceSignal>().RemoveListener(AddResource);
        }
    }
}
