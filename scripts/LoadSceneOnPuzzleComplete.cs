using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnPuzzleComplete : MonoBehaviour
{
    [Header("Name of the scene to load after puzzle completion")]
    [SerializeField] private string sceneToLoad = "LaboratoryScene";

    // Call this when the puzzle is fully solved
    public void OnPuzzleComplete()
    {
        if (SceneExists(sceneToLoad))
        {
            Debug.Log($"Puzzle completed! Loading scene: {sceneToLoad}");
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.LogError($"Scene '{sceneToLoad}' not found in Build Settings!");
        }
    }

    // Optional: check if the scene is listed in Build Settings
    private bool SceneExists(string name)
    {
        int sceneCount = SceneManager.sceneCountInBuildSettings;
        for (int i = 0; i < sceneCount; i++)
        {
            string path = SceneUtility.GetScenePathByBuildIndex(i);
            string sceneName = System.IO.Path.GetFileNameWithoutExtension(path);
            if (sceneName == name)
                return true;
        }
        return false;
    }
}
