using UnityEngine;
using UnityEngine.InputSystem;

public class SimpleFPS : MonoBehaviour
{
    public float speed = 5f;
    public float mouseSensitivity = 2f;

    float rotationX = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        
        Vector2 mouseDelta = Mouse.current.delta.ReadValue();

        float mouseX = mouseDelta.x * mouseSensitivity * 0.1f;
        float mouseY = mouseDelta.y * mouseSensitivity * 0.1f;

        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -80f, 80f);

        Camera.main.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
        transform.Rotate(Vector3.up * mouseX);

        
        float x = 0f;
        float z = 0f;

        if (Keyboard.current.aKey.isPressed) x = -1;
        if (Keyboard.current.dKey.isPressed) x = 1;
        if (Keyboard.current.wKey.isPressed) z = 1;
        if (Keyboard.current.sKey.isPressed) z = -1;

        Vector3 move = transform.right * x + transform.forward * z;
        transform.position += move * speed * Time.deltaTime;
    }
}
