using UnityEngine;
using UnityEngine.UI;

namespace UISwitcher
{
    public class MainUI : MonoBehaviour
    {
        [SerializeField] private GameObject mainPanel;
        [SerializeField] private Button mainButton;
        [SerializeField] private GameObject addPanel;
        [SerializeField] private Button addButton;  
        [SerializeField] private GameObject removePanel;
        [SerializeField] private Button removeButton;

        private void OnEnable()
        {
            mainButton.onClick.AddListener(MainPanel);
            addButton.onClick.AddListener(AddPanel);
            removeButton.onClick.AddListener(RemovePanel);
        }
        
        private void OnDisable()
        {
            mainButton.onClick.RemoveAllListeners();
            addButton.onClick.RemoveAllListeners();
            removeButton.onClick.RemoveAllListeners();
        }

        private void MainPanel()
        {
            DisablePanel();

            mainPanel.SetActive(true);
        }

        private void AddPanel()
        {
            DisablePanel();

            addPanel.SetActive(true);
        }

        private void RemovePanel()
        {
            DisablePanel();

            removePanel.SetActive(true);
        }

        private void DisablePanel()
        {
            mainPanel.SetActive(false);
            addPanel.SetActive(false);
            removePanel.SetActive(false);
        }
    }
}
