using UnityEngine;
using UnityEngine.UI;

namespace ResourceSystem
{
    public class ResourceView : MonoBehaviour
    {
        [SerializeField] private Text text;
        
        private ResourceEnum _resource;

        public void SetData(ResourceEnum resource)
        {
            _resource = resource;
        }
        
        public void UpdatedText(int resourceCount)
        {
            text.text = $"{_resource} \n \n {resourceCount}";
        }
    }
}