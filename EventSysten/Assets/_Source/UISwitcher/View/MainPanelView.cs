using Signals;
using UnityEngine;
using UnityEngine.UI;

namespace UISwitcher.View
{
    public class MainPanelView : MonoBehaviour
    {
        [SerializeField] private Button buttonReset;
        
        void Start()
        {
            buttonReset.onClick.AddListener(OnButtonClicked);
        }

        private void OnButtonClicked()
        {
            Until.Signals.Get<ClearResourceSignal>().Dispatch();
        }
    }
}