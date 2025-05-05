using UnityEngine;

public class GünlükInteract : MonoBehaviour
{
    public GameObject GünlükPanel; 

    void OnMouseDown()
    {
        if (GünlükPanel != null)
        {
            GünlükPanel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
