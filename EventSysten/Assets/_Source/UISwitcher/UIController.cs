using System.Collections.Generic;
using ResourceSystem;
using UISwitcher.UIState;
using UnityEngine;
using UnityEngine.UI;

namespace UISwitcher
{
    public class UIController : MonoBehaviour
    {
        [Header("Main System")]
        [SerializeField] private GameObject mainPanel;
        [SerializeField] private Button mainButton;
        [SerializeField] private GameObject addPanel;
        [SerializeField] private Button addButton;
        [SerializeField] private GameObject removePanel;
        [SerializeField] private Button removeButton;

        [Header("Control System")] 
        [SerializeField] private UIView ui;
        [SerializeField] private Resource[] resources;
        [SerializeField] private Button buttonReset;

        [Header("Add System")]
        [SerializeField] private Dropdown dropdownAdd;
        [SerializeField] private InputField inputFieldAdd;
        [SerializeField] private Button buttonAdd;
        
        [Header("Remove System")]
        [SerializeField] private Dropdown dropdownRemove;
        [SerializeField] private InputField inputFieldRemove;
        [SerializeField] private Button buttonRemove;

        private IUIState _uiMainMenu;
        private IUIState _uiAddMenu;
        private IUIState _uiRemoveMenu;

        private void Awake()
        {
            mainButton.onClick.AddListener(MainPanel);
            addButton.onClick.AddListener(AddPanel);
            removeButton.onClick.AddListener(RemovePanel);

            _uiMainMenu = new UIMainMenu(resources, buttonReset);
            _uiAddMenu = new UIAddMenu(resources, dropdownAdd, inputFieldAdd, buttonAdd);
            _uiRemoveMenu = new UIRemoveMenu(resources, dropdownRemove, inputFieldRemove, buttonRemove);
        }

        private void MainPanel()
        {
            DisablePanel();

            ExitStateUI();
            _uiMainMenu.Enter();

            mainPanel.SetActive(true);
        }

        private void AddPanel()
        {
            DisablePanel();

            ExitStateUI();
            _uiAddMenu.Enter();

            addPanel.SetActive(true);
        }

        private void RemovePanel()
        {
            DisablePanel();

            ExitStateUI();
            _uiRemoveMenu.Enter();

            removePanel.SetActive(true);
        }

        private void DisablePanel()
        {
            mainPanel.SetActive(false);
            addPanel.SetActive(false);
            removePanel.SetActive(false);
        }

        private void ExitStateUI()
        {
            _uiMainMenu.Exit();
            _uiAddMenu.Exit();
            _uiRemoveMenu.Exit();
        }
    }
}