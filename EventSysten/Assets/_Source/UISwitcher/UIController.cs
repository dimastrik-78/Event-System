using ResourceSystem;
using UISwitcher.UIState;
using UnityEngine;
using UnityEngine.UI;

namespace UISwitcher
{
    public class UIController : MonoBehaviour
    {
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

        private UIMainMenu _uiMainMenu;
        private UIAddMenu _uiAddMenu;
        private UIRemoveMenu _uiRemoveMenu;

        private void Awake()
        {
            buttonAdd.onClick.AddListener(AddResource);
            buttonRemove.onClick.AddListener(RemoveResource);
            buttonReset.onClick.AddListener(ResetResource);

            _uiMainMenu = new UIMainMenu();
            _uiAddMenu = new UIAddMenu();
            _uiRemoveMenu = new UIRemoveMenu();
        }

        private void ResetResource()
        {
            for (int i = 0; i < resources.Length; i++)
            {
                resources[i].Cleare();
            }
        }

        private void AddResource()
        {
            Resource resource = null;
            
            resource = FindResource(FindTypeResource(dropdownAdd));
            
            resource.UpdateCountResource(int.Parse(inputFieldAdd.text));
            ui.UpdateCountResource(resource);
        }
        
        private void RemoveResource()
        {
            
        }

        private ResourceEnum FindTypeResource(Dropdown dropdown)
        {
            if (dropdown.value == 0)
            {
                return ResourceEnum.Diamond;
            }
            else if (dropdownAdd.value == 1)
            {
                return ResourceEnum.Gold;
            }

            return ResourceEnum.Iron;
        }

        private Resource FindResource(ResourceEnum resourceIndex)
        {
            foreach (var result in resources)
            {
                if (result.GetTypeResource() == resourceIndex)
                {
                    return result;
                }
            }

            return null;
        }
    }
}