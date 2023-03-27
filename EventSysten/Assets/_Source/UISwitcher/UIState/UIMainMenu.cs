using ResourceSystem;
using System.Collections.Generic;
using UnityEngine.UI;

namespace UISwitcher.UIState
{
    class UIMainMenu : IUIState
    {
        private readonly List<ResourceController> _resources;
        private readonly Button _button;

        public UIMainMenu(List<ResourceController> resources, Button button)
        {
            _resources = resources;
            _button = button;
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
            _button.onClick.AddListener(ResetResource);
        }

        public void Exit()
        {
            _button.onClick.RemoveAllListeners();
        }
    }
}
