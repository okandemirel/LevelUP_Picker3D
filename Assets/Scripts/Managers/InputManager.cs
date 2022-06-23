using Managers;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private void Update()
    {
        EventManager.Instance.onInputDragged?.Invoke(new InputParams()
        {
            XValue = GetInputData().x,
            YValue = GetInputData().y
        });
    }

    private Vector2 GetInputData()
    {
        return new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }
}