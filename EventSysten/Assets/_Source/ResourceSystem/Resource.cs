using System;
using UnityEngine;
using UnityEngine.UI;

namespace ResourceSystem
{
    public class Resource : MonoBehaviour // разделить на view and controller
    {
        [SerializeField] private Text text;
        [SerializeField] private ResourceEnum resource;

        private int _countResource;

        private void Awake()
        {
            UpdateText();
        }

        public void Cleare()
        {
            _countResource = 0;

            UpdateText();
        }

        public void UpdateCountResource(int add)
        {
            _countResource += add;

            if (_countResource < 0)
            {
                _countResource = 0;
            }

            UpdateText();
        }
        
        public int GetCountResource()
        {
            return _countResource;
        }

        public ResourceEnum GetTypeResource()
        {
            return resource;
        }

        private void UpdateText()
        {
            text.text = $"{resource} \n \n {_countResource}";
        }
    }
}