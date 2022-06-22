using UnityEngine;

public class InputManager : MonoBehaviour
{
    private void Update()
    {
        EventManager.Instance.onInputDragged?.Invoke(new HorizontalInputParams()
        {
            XValue = GetInputData()
        });
    }

    private float GetInputData()
    {
        return Input.GetAxisRaw("Horizontal");
    }
}