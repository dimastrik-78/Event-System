using EventSystem;
using UnityEngine;
using UnityEngine.UI;

namespace UISwitcher.View
{
    public class MainPanelView : MonoBehaviour
    {
        [SerializeField] private OnSomeActionCallSO onSomeActionCallSO;
        [SerializeField] private Button buttonReset;
        
        private OnSomeActionCallSO _onSomeActionCallSO;
        
        void Awake()
        {
            buttonReset.onClick.AddListener(OnButtonClicked);
        }

        private void OnButtonClicked()
        {
            onSomeActionCallSO.InvokeListener();
        }
    }
}