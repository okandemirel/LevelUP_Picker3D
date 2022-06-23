using Managers;
using UnityEngine;

namespace Controllers
{
    public class CollectableController : MonoBehaviour
    {
        [SerializeField] private Collider collider;


        private void Awake()
        {
            collider = GetComponent<Collider>();
        }

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

        private void OnObjeTemasEdilince()
        {
            // if (collider.GetInstanceID() == value)
            gameObject.SetActive(false);
        }
    }
}