using ResourceSystem;
using UISwitcher;
using UnityEngine;
using UnityEngine.UI;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private UIController uiController;

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

        void Awake()
        {
            
        }
    }
}
