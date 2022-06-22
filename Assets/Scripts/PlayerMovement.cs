using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Self Variables

    #region Serialized Variables

    [SerializeField] private int speed = 5;

    #endregion

    #region Private Variables

    private Rigidbody _rigidbody = new Rigidbody();

    private float _inputValue;

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

    private void OnUpdateInputParams(HorizontalInputParams inputParams)
    {
        _inputValue = inputParams.XValue;
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }


    private void MovePlayer()
    {
        _rigidbody.velocity =
            new Vector3(_inputValue * speed, _rigidbody.velocity.y, speed);
        // // transform.Translate(new Vector3(_inputValues.x * speed * Time.deltaTime, 0,
        // //     _inputValues.y * speed * Time.deltaTime));
        // _rigidbody.AddForce(
        //     new Vector3(_inputValues.x * speed * Time.fixedDeltaTime, 0,
        //         _inputValues.y * speed * Time.fixedDeltaTime),
        //     ForceMode.Impulse);
        // // transform.position += new Vector3(_inputValues.x, 0,
        // //     _inputValues.y) * speed * Time.deltaTime;
    }
}