using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class RestartInputHandler : MonoBehaviour
{
    public Button restartButton;
    public InputAction restartAction;

    private void OnEnable()
    {
        restartAction.Enable();
    }

    private void OnDisable()
    {
        restartAction.Disable();
    }

    void Update()
    {
        if (restartAction.triggered)
        {
            restartButton.onClick.Invoke();
        }
    }
}
