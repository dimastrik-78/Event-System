using ResourceSystem;
using UnityEngine;
using UnityEngine.UI;

namespace UISwitcher.AddUI
{
    public class UIController : MonoBehaviour
    {
        [Header("Control System")] 
        [SerializeField] private UIView ui;
        [SerializeField] private Resource[] resources;

        [Header("Add System")]
        [SerializeField] private Dropdown dropdownAdd;
        [SerializeField] private InputField inputFieldAdd;
        [SerializeField] private Button buttonAdd;
        
        [Header("Remove System")]
        [SerializeField] private Dropdown dropdownRemove;
        [SerializeField] private InputField inputFieldRemove;
        [SerializeField] private Button buttonRemove;


        private void Awake()
        {
            buttonAdd.onClick.AddListener(AddResource);
            buttonRemove.onClick.AddListener(RemoveResource);
            
        }

        private void AddResource()
        {
            Resource resource = null;
            
            if (dropdownAdd.captionText.text == ResourceEnum.Diamond.ToString())
            {
                resource = FindResource(ResourceEnum.Diamond);
            }
            else if (dropdownAdd.captionText.text == ResourceEnum.Gold.ToString())
            {
                resource = FindResource(ResourceEnum.Gold);
            }
            else if (dropdownAdd.captionText.text == ResourceEnum.Iron.ToString())
            {
                resource = FindResource(ResourceEnum.Iron);
            }
            
            resource.AddResource(1);
            ui.UpdateCountResource(resource);
        }
        
        private void RemoveResource()
        {
            
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