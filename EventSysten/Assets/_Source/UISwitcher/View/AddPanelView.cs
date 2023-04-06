using Signals;
using UnityEngine;
using UnityEngine.UI;
using Until;

namespace UISwitcher.View
{
    public class AddPanelView : MonoBehaviour
    {
        [SerializeField] private Dropdown dropdownAdd;
        [SerializeField] private InputField inputFieldAdd;
        [SerializeField] private Button buttonAdd;
        
        void Start()
        {
            buttonAdd.onClick.AddListener(OnButtonClicked);
        }

        private void OnButtonClicked()
        {
            Until.Signals.Get<AddResourceSignal>().Dispatch(MyExtensions.FindTypeResource(dropdownAdd), int.Parse(inputFieldAdd.text));
        }
    }
}
