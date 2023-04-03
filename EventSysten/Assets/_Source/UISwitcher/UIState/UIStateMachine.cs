using System.Collections.Generic;
using ResourceSystem;
using UnityEngine.UI;
using Until;

namespace UISwitcher.UIState
{
    public class UIStateMachine : ASignal<int>
    {
        private IUIState _currentState;
        
        private readonly Dictionary<int, IUIState> _states;
        
        public UIStateMachine(List<ResourceController> resourceController,
            Button buttonReset,
            Dropdown dropdownAdd, InputField inputFieldAdd, Button buttonAdd,
            Dropdown dropdownRemove, InputField inputFieldRemove, Button buttonRemove)
        {
            _states = new Dictionary<int, IUIState>
            {
                { 0, new UIMainMenu(resourceController, buttonReset) },
                { 1, new UIAddMenu(resourceController, dropdownAdd, inputFieldAdd, buttonAdd) },
                { 2, new UIRemoveMenu(resourceController, dropdownRemove, inputFieldRemove, buttonRemove) }
            };
            
            Signals.Get<UIStateMachine>().AddListener(ChangeState);
        }

        public void ChangeState(int id)
        {
            _currentState?.Exit();
            _currentState = _states[id];
            _currentState.Enter();
        }
    }
}