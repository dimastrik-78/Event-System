using ResourceSystem;
using System.Collections.Generic;
using UnityEngine.UI;

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
        }

        public void Exit()
        {
        }
    }
}
