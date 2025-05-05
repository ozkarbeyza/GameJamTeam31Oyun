using UnityEngine;
using UnityEngine.UI;

public class CubeClick : MonoBehaviour
{
    public Image image;
    private float imageOpenedTime;
    private bool imageWasOpened = false;

    void Start()
    {
        image.enabled = false;
    }

    void OnMouseDown()
    {
        // Toggle image
        image.enabled = !image.enabled;

        if (image.enabled)
        {
            imageOpenedTime = Time.time;
            imageWasOpened = true;
        }
    }

    void Update()
    {
        if (image.enabled && Input.GetMouseButtonDown(0))
        {
            // Prevent immediate closing
            if (Time.time - imageOpenedTime < 0.1f)
                return;

            // Close image only if clicked outside the cube
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (!Physics.Raycast(ray, out RaycastHit hit) || hit.transform != transform)
            {
                image.enabled = false;

                // Destroy the cube after the image is closed
                if (imageWasOpened)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}