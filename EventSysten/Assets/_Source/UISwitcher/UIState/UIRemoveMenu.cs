using ResourceSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;
using Until;

namespace UISwitcher.UIState
{
    class UIRemoveMenu : IUIState
    {
        private Resource[] _resources;
        private Dropdown _dropdown;
        private InputField _inputField;
        private Button _button;

        public UIRemoveMenu(Resource[] resources, Dropdown dropdown, InputField inputField, Button button)
        {
            _resources = resources;
            _dropdown = dropdown;
            _inputField = inputField;
            _button = button;
        }

        private void RemoveResource()
        {
            Resource resource = MyExtensions.FindResource(_resources, MyExtensions.FindTypeResource(_dropdown));

            resource.UpdateCountResource(-int.Parse(_inputField.text));
        }

        public void Enter()
        {
            _button.onClick.AddListener(RemoveResource);
        }

        public void Exit()
        {
            _button.onClick.RemoveAllListeners();
        }
    }
}
