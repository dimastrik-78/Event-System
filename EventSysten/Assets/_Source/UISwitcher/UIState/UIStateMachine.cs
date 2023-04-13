using System;
using System.Collections.Generic;
using ResourceSystem;

namespace UISwitcher.UIState
{
    public class UIStateMachine
    {
        private IUIState _currentState;
        
        private readonly Dictionary<Type, IUIState> _states;
        
        public UIStateMachine(List<ResourceController> resourceController)
        {
            _states = new Dictionary<Type, IUIState>
            {
                { typeof(UIMainMenu), new UIMainMenu(resourceController) },
                { typeof(UIAddMenu), new UIAddMenu(resourceController) },
                { typeof(UIRemoveMenu), new UIRemoveMenu(resourceController) }
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