using System;
using UnityEngine;
using UnityEngine.UI;

namespace ResourceSystem
{
    public class Resource : MonoBehaviour
    {
        [SerializeField] private Text text;
        [SerializeField] private ResourceEnum resource;

        private int _countResource;

        private void Awake()
        {
            
        }

        public void AddResource(int add)
        {
            _countResource += add;
        }
        
        public int GetCountResource()
        {
            return _countResource;
        }

        public ResourceEnum GetTypeResource()
        {
            return resource;
        }
    }
}