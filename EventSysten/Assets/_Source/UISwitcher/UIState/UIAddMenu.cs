using ResourceSystem;
using System.Collections.Generic;
using UnityEngine.UI;
using Until;

namespace UISwitcher.UIState
{
    class UIAddMenu : IUIState
    {
        private readonly List<ResourceController> _resources;
        private readonly Dropdown _dropdown;
        private readonly InputField _inputField;
        private readonly Button _button;

        public UIAddMenu(List<ResourceController> resources, Dropdown dropdown, InputField inputField, Button button)
        {
            _resources = resources;
            _dropdown = dropdown;
            _inputField = inputField;
            _button = button;
        }

        private void AddResource()
        {
            ResourceController resourceView = MyExtensions.FindResource(_resources, MyExtensions.FindTypeResource(_dropdown));

            resourceView.UpdateCountResource(int.Parse(_inputField.text));
        }

        public void Enter()
        {
            _button.onClick.AddListener(AddResource);
        }

        public void Exit()
        {
            _button.onClick.RemoveAllListeners();
        }
    }
}
