namespace ResourceSystem
{
    public class ResourceController
    {
        private readonly ResourceEnum _resource;
        private readonly ResourceView _resourceView;
        
        private int _countResource;
        
        public ResourceController(ResourceEnum resource, ResourceView resourceView)
        {
            _resource = resource;
            _resourceView = resourceView;

            SetSettings();
        }

        private void SetSettings()
        {
            _resourceView.SetData(_resource);
            
            _resourceView.UpdatedText(_countResource);
        }

        public void Clear()
        {
            _countResource = 0;

            _resourceView.UpdatedText(_countResource);
        }
        
        public void UpdateCountResource(int add)
        {
            _countResource += add;

            if (_countResource < 0)
            {
                _countResource = 0;
            }

            _resourceView.UpdatedText(_countResource);
        }

        public ResourceEnum GetTypeResource()
        {
            return _resource;
        }
    }
}