using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    public GameObject textPanel; // The full panel GameObject (can include background + text)
    private float panelOpenedTime;

    void Start()
    {
        if (textPanel != null)
            textPanel.SetActive(false);
    }

    void OnMouseDown()
    {
        if (textPanel == null) return;

        // Toggle panel visibility
        bool isActive = textPanel.activeSelf;
        textPanel.SetActive(!isActive);

        // Record time it was opened
        if (!isActive)
            panelOpenedTime = Time.time;
        
    }

    void Update()
    {
        if (textPanel != null && textPanel.activeSelf && Input.GetMouseButtonDown(0))
        {
            // Avoid closing immediately after opening
            if (Time.time - panelOpenedTime < 0.1f)
                return;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (!Physics.Raycast(ray, out RaycastHit hit) || hit.transform != transform)
            {
                textPanel.SetActive(false);
            }
        }
    }
}
