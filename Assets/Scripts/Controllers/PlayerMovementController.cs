using Managers;
using UnityEngine;

namespace Controllers
{
    public class PlayerMovementController : MonoBehaviour
    {
        #region Self Variables

        #region Serialized Variables

        [SerializeField] private int speed = 5;

        #endregion

        #region Private Variables

        private Rigidbody _rigidbody = new Rigidbody();

        private Vector2 _inputValues;

        #endregion

        #endregion

        private void Awake()
        {
            GetReferences();
        }

        private void GetReferences()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        #region Event Subscription

        private void OnEnable()
        {
            SubscribeEvents();
        }

        private void SubscribeEvents()
        {
            EventManager.Instance.onInputDragged += OnUpdateInputParams;
        }

        private void UnsubscribeEvents()
        {
            EventManager.Instance.onInputDragged -= OnUpdateInputParams;
        }

        private void OnDisable()
        {
            UnsubscribeEvents();
        }

        #endregion

        private void OnUpdateInputParams(InputParams inputParams)
        {
            _inputValues = new Vector2(inputParams.XValue, inputParams.YValue);
        }

        private void FixedUpdate()
        {
            MovePlayer();
        }


        private void MovePlayer()
        {
            _rigidbody.velocity =
                new Vector3(_inputValues.x * speed, _rigidbody.velocity.y, _inputValues.y);
        }
    }
}