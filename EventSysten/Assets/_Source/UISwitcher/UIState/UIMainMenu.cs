using ResourceSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;

namespace UISwitcher.UIState
{
    class UIMainMenu : IUIState
    {
        private Resource[] _resources;
        private Button _button;

        public UIMainMenu(Resource[] resources, Button button)
        {
            _resources = resources;
            _button = button;
        }

        private void ResetResource()
        {
            for (int i = 0; i < _resources.Length; i++)
            {
                _resources[i].Cleare();
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
