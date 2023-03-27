using ResourceSystem;
using UnityEngine;
using UnityEngine.UI;

namespace UISwitcher
{
    public class UIView : MonoBehaviour
    {
        [SerializeField] private ResourceView[] resources;
        [SerializeField] private Dropdown[] dropdowns;

        // private void Awake()
        // {
        //     dropdowns[0].options.Add((Dropdown.OptionData)ResourceEnum.Diamond);
        // }
    }
}