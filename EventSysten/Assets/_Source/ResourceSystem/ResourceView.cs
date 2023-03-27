using UnityEngine;
using UnityEngine.UI;

namespace ResourceSystem
{
    public class ResourceView : MonoBehaviour
    {
        [SerializeField] private Text text;
        [SerializeField] private ResourceEnum resource;

        private ResourceController _resourceController;

        private void UpdatedText()
        {
            text.text = $"{resource} \n \n {_resourceController.GetCountResource()}";
        }
        
        public void StartWork()
        {
            _resourceController = new(resource);
            _resourceController.OnUpdateText += UpdatedText;
            
            UpdatedText();
        }
        
        public ResourceController GetController()
        {
            return _resourceController;
        }
    }
}