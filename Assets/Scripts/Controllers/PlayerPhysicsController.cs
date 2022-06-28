using System;
using Managers;
using UnityEngine;

namespace Controllers
{
    public class PlayerPhysicsController : MonoBehaviour
    {
        #region Self Variables

        #region Serialized Variables

        [SerializeField] private PlayerManager manager;
        [SerializeField] private new Collider collider;
        [SerializeField] private new Rigidbody rigidbody;

        #endregion

        #endregion

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("StageArea"))
            {
                //Playerı durdur, toplara kuvvet uygula
            }

            if (other.CompareTag("MiniGameArea"))
            {
                //MiniGame'i başlat
            }
        }

        public void SetPhysicsData()
        {
        }
    }
}