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
        
        [Header("Add System")]
        [SerializeField] private GameObject addPanel;
        [SerializeField] private Button addButton;
        
        [Header("Remove System")]
        [SerializeField] private GameObject removePanel;
        [SerializeField] private Button removeButton;
        
        private UIStateMachine _stateMachine;

        private void Awake()
        {
            mainButton.onClick.AddListener(MainPanel);
            addButton.onClick.AddListener(AddPanel);
            removeButton.onClick.AddListener(RemovePanel);
        }

        private void MainPanel()
        {
            DisablePanel();

            _stateMachine.ChangeState(typeof(UIMainMenu));

            mainPanel.SetActive(true);
        }

        private void AddPanel()
        {
            DisablePanel();

            _stateMachine.ChangeState(typeof(UIAddMenu));

            addPanel.SetActive(true);
        }

        private void RemovePanel()
        {
            DisablePanel();

            _stateMachine.ChangeState(typeof(UIRemoveMenu));

            removePanel.SetActive(true);
        }

        private void DisablePanel()
        {
            mainPanel.SetActive(false);
            addPanel.SetActive(false);
            removePanel.SetActive(false);
        }
        
        public void SetStateMachine(UIStateMachine stateMachine)
        {
            _stateMachine = stateMachine;
        }
    }
}