using EventSystem;
using UnityEngine;
using UnityEngine.UI;
using Until;

namespace UISwitcher.View
{
    public class AddPanelView : MonoBehaviour
    {
        [SerializeField] private OnSomeActionCallSO onSomeActionCallSO;
        [SerializeField] private Dropdown dropdownAdd;
        [SerializeField] private InputField inputFieldAdd;
        [SerializeField] private Button buttonAdd;
        
        void Awake()
        {
            buttonAdd.onClick.AddListener(OnButtonClicked);
        }

        private void OnButtonClicked()
        {
            onSomeActionCallSO.InvokeListener(MyExtensions.FindTypeResource(dropdownAdd.value), int.Parse(inputFieldAdd.text));
        }
    }
}
