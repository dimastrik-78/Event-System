using UISwitcher;
using UISwitcher.AddUI;
using UnityEngine;
using UnityEngine.Serialization;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [FormerlySerializedAs("ui")] [SerializeField] private UIController uiController;
        
        void Awake()
        {
            
        }
    }
}
