using System.Collections.Generic;
using ResourceSystem;
using UISwitcher;
using UISwitcher.UIState;
using UnityEngine;
using Until;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private UIController uiController;
        [SerializeField] private ResourceView[] resourceViews;

        private readonly List<ResourceController> _resourceController = new();
        
        private UIStateMachine _stateMachine;

        void Start()
        {
            ActivateResourceView();

            _stateMachine = new UIStateMachine(_resourceController);

            uiController.SetStateMachine(_stateMachine);
        }

        private void ActivateResourceView()
        {
            for (int i = 0; i < resourceViews.Length; i++)
            {
                _resourceController.Add(new ResourceController(MyExtensions.FindTypeResource(i), resourceViews[i]));
            }
        }
    }
}
