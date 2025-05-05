using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleEntrance : MonoBehaviour
{
    [SerializeField] private string sceneToLoad;

    private void OnMouseDown()
    {
        // Only works with mouse or tap (on actual GameObject with Collider)
        if (!string.IsNullOrEmpty(sceneToLoad))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.LogWarning("Scene name is not set.");
        }
    }
}
