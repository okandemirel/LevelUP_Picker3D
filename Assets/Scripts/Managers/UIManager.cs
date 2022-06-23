using TMPro;
using UnityEngine;

namespace Managers
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI text;


        private int _value;

        private void OnEnable()
        {
            SubscribeEvents();
        }

        private void SubscribeEvents()
        {
            EventManager.Instance.onObjeTemasEdince += OnObjeTemasEdilince;
        }

        private void UnsubscribeEvents()
        {
            EventManager.Instance.onObjeTemasEdince -= OnObjeTemasEdilince;
        }

        private void OnDisable()
        {
            UnsubscribeEvents();
        }

        public void OnObjeTemasEdilince()
        {
            text.text = $"{++_value}";
        }
    }
}