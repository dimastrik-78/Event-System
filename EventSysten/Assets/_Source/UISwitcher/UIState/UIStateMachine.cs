using System.Collections.Generic;
using ResourceSystem;

namespace UISwitcher.UIState
{
    public class UIStateMachine
    {
        private IUIState _currentState;
        
        private readonly Dictionary<int, IUIState> _states;
        
        public UIStateMachine(List<ResourceController> resourceController)
        {
            _states = new Dictionary<int, IUIState>
            {
                { 0, new UIMainMenu(resourceController) },
                { 1, new UIAddMenu(resourceController) },
                { 2, new UIRemoveMenu(resourceController) }
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