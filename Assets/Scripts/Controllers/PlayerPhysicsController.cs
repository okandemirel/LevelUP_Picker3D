using System;
using System.Collections.Generic;
using Managers;
using UnityEngine;

namespace Controllers
{
    public class PlayerPhysicsController : MonoBehaviour
    {
        #region Self Variables

        #region Serialized Variables

        private List<GameObject> gameObjectList = new List<GameObject>();

        private UIManager _uiManager;

        #endregion

        #endregion

        private void Awake()
        {
            _uiManager = FindObjectOfType<UIManager>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Collectable"))
            {
                //other.gameObject.SetActive(false);
                _uiManager.OnObjeTemasEdilince();
                EventManager.Instance.onObjeTemasEdince?.Invoke();
            }
        }
    }
}