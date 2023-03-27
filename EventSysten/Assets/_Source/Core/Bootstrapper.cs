using System.Collections.Generic;
using ResourceSystem;
using UISwitcher;
using UISwitcher.UIState;
using UnityEngine;
using UnityEngine.UI;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private UIController uiController;

        [Header("Control System")]
        [SerializeField] private ResourceView[] resources;
        [SerializeField] private Button buttonReset;

        [Header("Add System")]
        [SerializeField] private Dropdown dropdownAdd;
        [SerializeField] private InputField inputFieldAdd;
        [SerializeField] private Button buttonAdd;

        [Header("Remove System")]
        [SerializeField] private Dropdown dropdownRemove;
        [SerializeField] private InputField inputFieldRemove;
        [SerializeField] private Button buttonRemove;

        private UIStateMachine _stateMachine;
        private List<ResourceController> _resourceController;

        void Start()
        {
            ActivateResourceView();
            GetResourceControllers();
            
            _stateMachine = new UIStateMachine(_resourceController,
                buttonReset,
                dropdownAdd, inputFieldAdd, buttonAdd,
                dropdownRemove, inputFieldRemove, buttonRemove);

            uiController.SetStateMachine(_stateMachine);
        }

        private void ActivateResourceView()
        {
            foreach (var resource in resources)
            {
                resource.StartWork();
            }
        }
        
        private void GetResourceControllers()
        {
            _resourceController = new List<ResourceController>();
            foreach (var resource in resources)
            {
                _resourceController.Add(resource.GetController());
            }
        }
    }
}
