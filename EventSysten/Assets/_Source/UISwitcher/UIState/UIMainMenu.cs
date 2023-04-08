using ResourceSystem;
using System.Collections.Generic;
using Signals;

namespace UISwitcher.UIState
{
    class UIMainMenu : IUIState
    {
        private readonly List<ResourceController> _resources;

        public UIMainMenu(List<ResourceController> resources)
        {
            _resources = resources;
        }

        private void ResetResource()
        {
            foreach (var resource in _resources)
            {
                resource.Clear();
            }
        }

        public void Enter()
        {
            Until.Signals.Get<ClearResourceSignal>().AddListener(ResetResource);
        }

        public void Exit()
        {
            Until.Signals.Get<ClearResourceSignal>().RemoveListener(ResetResource);
        }
    }
}
