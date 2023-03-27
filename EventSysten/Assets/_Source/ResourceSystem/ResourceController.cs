using System;

namespace ResourceSystem
{
    public class ResourceController
    {
        public event Action OnUpdateText;
        
        private readonly ResourceEnum _resource;
        private int _countResource;
        
        public ResourceController(ResourceEnum resource)
        {
            _resource = resource;
        }

        public void Clear()
        {
            _countResource = 0;

            OnUpdateText?.Invoke();
        }
        
        public void UpdateCountResource(int add)
        {
            _countResource += add;

            if (_countResource < 0)
            {
                _countResource = 0;
            }

            OnUpdateText?.Invoke();
        }

        public ResourceEnum GetTypeResource()
        {
            return _resource;
        }
        
        public int GetCountResource()
        {
            return _countResource;
        }
    }
}