using EventSystem;
using UnityEngine;
using UnityEngine.UI;
using Until;

namespace UISwitcher.View
{
    public class RemovePanelView : MonoBehaviour
    {
        [SerializeField] private OnSomeActionCallSO onSomeActionCallSO;
        [SerializeField] private Dropdown dropdownRemove;
        [SerializeField] private InputField inputFieldRemove;
        [SerializeField] private Button buttonRemove;
        
        void Awake()
        {
            buttonRemove.onClick.AddListener(OnButtonClicked);
        }

        private void OnButtonClicked()
        {
            onSomeActionCallSO.InvokeListener(MyExtensions.FindTypeResource(dropdownRemove.value), int.Parse(inputFieldRemove.text));
        }
    }
}