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

            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (!Physics.Raycast(ray, out RaycastHit hit) || hit.transform != transform)
            {
                image.enabled = false;

                
                if (imageWasOpened)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}
