using Signals;
using UnityEngine;
using UnityEngine.UI;
using Until;

namespace UISwitcher.View
{
    public class RemovePanelView : MonoBehaviour
    {
        [SerializeField] private Dropdown dropdownRemove;
        [SerializeField] private InputField inputFieldRemove;
        [SerializeField] private Button buttonRemove;
        
        void Start()
        {
            buttonRemove.onClick.AddListener(OnButtonClicked);
        }

        private void OnButtonClicked()
        {
            Until.Signals.Get<RemoveResourceSignal>().Dispatch(MyExtensions.FindTypeResource(dropdownRemove.value), int.Parse(inputFieldRemove.text));
        }
    }
}