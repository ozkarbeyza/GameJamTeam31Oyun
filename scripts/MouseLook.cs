using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 50f;
    public Transform playerBody; 
    private float xRotation = 0f; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined; 
        Cursor.visible = true; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Cursor.lockState = CursorLockMode.Locked; 
            Cursor.visible = false; // Hide the cursor

            float mouseX = Input.GetAxisRaw("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxisRaw("Mouse Y") * mouseSensitivity * Time.deltaTime;

            playerBody.Rotate(Vector3.up * mouseX); // Rotate the player's body horizontally

            xRotation -= mouseY; // Invert the vertical rotation
            xRotation = Mathf.Clamp(xRotation, -90f, 90f); 

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); 
        }
        else
        {
            Cursor.lockState = CursorLockMode.None; 
            Cursor.visible = true; 
        }
    }
}
