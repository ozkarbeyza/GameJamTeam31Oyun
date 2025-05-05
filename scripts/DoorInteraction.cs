using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorInteraction : MonoBehaviour
{
    
    public string endingSceneName = "GameCompleteScene";

    
    public bool CanLoadEndingScene = false;

    
    private void OnMouseDown()
    {
        if (CanLoadEndingScene)
        {
            LoadEndingScene();
        }
    }

    
    void LoadEndingScene()
    {
        SceneManager.LoadScene(endingSceneName);
    }
}
