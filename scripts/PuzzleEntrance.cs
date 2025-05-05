using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleEntrance : MonoBehaviour
{
    [SerializeField] private string sceneToLoad;

    private void OnMouseDown()
    {
        
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
