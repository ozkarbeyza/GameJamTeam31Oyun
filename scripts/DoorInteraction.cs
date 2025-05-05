using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorInteraction : MonoBehaviour
{
    // Define the scene name for the ending
    public string endingSceneName = "GameCompleteScene";

    // This flag ensures the door can only load the scene after all objects are clicked
    public bool CanLoadEndingScene = false;

    // This method is called when the user clicks on the door (or interacts with the collider)
    private void OnMouseDown()
    {
        if (CanLoadEndingScene)
        {
            LoadEndingScene();
        }
    }

    // This method loads the ending scene
    void LoadEndingScene()
    {
        SceneManager.LoadScene(endingSceneName);
    }
}
