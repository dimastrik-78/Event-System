using System.Collections.Generic;
using ResourceSystem;
using UISwitcher;
using UISwitcher.UIState;
using UISwitcher.View;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private UIController uiController;

        [SerializeField] private MainPanelView mainPanelView;
        [SerializeField] private AddPanelView addPanelView;
        [SerializeField] private RemovePanelView removePanelView;

        private UIStateMachine _stateMachine;
        private List<ResourceController> _resourceController;

        void Start()
        {
            // ActivateResourceView();
            // GetResourceControllers();
            
            _stateMachine = new UIStateMachine(_resourceController);

            uiController.SetStateMachine(_stateMachine);
        }

        // private void ActivateResourceView()
        // {
        //     for (int i = 0; i < ; i++)
        //     {
        //         new ResourceController();
        //     }
        // }
        
        // private void GetResourceControllers()
        // {
        //     _resourceController = new List<ResourceController>();
        //     foreach (var resource in resources)
        //     {
        //         _resourceController.Add(resource.GetController());
        //     }
        // }
    }
}
