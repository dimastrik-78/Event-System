using System;
using System.Collections.Generic;
using EventSystem;
using ResourceSystem;

namespace UISwitcher.UIState
{
    public class UIStateMachine
    {
        private IUIState _currentState;
        
        private readonly Dictionary<Type, IUIState> _states;
        
        public UIStateMachine(List<ResourceController> resourceController, OnSomeActionCallSO onSomeActionCallSO)
        {
            _states = new Dictionary<Type, IUIState>
            {
                { typeof(UIMainMenu), new UIMainMenu(resourceController, onSomeActionCallSO) },
                { typeof(UIAddMenu), new UIAddMenu(resourceController, onSomeActionCallSO) },
                { typeof(UIRemoveMenu), new UIRemoveMenu(resourceController, onSomeActionCallSO) }
            };
        }

        public void ChangeState(Type type)
        {
            _currentState?.Exit();
            _currentState = _states[type];
            _currentState.Enter();
        }
    }
}