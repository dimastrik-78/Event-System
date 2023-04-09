using System.Collections.Generic;
using EventSystem;
using ResourceSystem;

namespace UISwitcher.UIState
{
    public class UIStateMachine
    {
        private IUIState _currentState;
        
        private readonly Dictionary<int, IUIState> _states;
        
        public UIStateMachine(List<ResourceController> resourceController, OnSomeActionCallSO onSomeActionCallSO)
        {
            _states = new Dictionary<int, IUIState>
            {
                { 0, new UIMainMenu(resourceController, onSomeActionCallSO) },
                { 1, new UIAddMenu(resourceController, onSomeActionCallSO) },
                { 2, new UIRemoveMenu(resourceController, onSomeActionCallSO) }
            };
        }

        public void ChangeState(int id)
        {
            _currentState?.Exit();
            _currentState = _states[id];
            _currentState.Enter();
        }
    }
}