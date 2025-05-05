using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public GameObject[] interactiveObjects;

    
    private int objectsClicked = 0;

   
    public string endingSceneName = "EndingScene";

    // Start is called before the first frame update
    void Start()
    {
        
        objectsClicked = 0;
    }

    
    public void ObjectClicked()
    {
        
        objectsClicked++;

        
        if (objectsClicked == interactiveObjects.Length)
        {
            
            EnableDoorInteraction();
        }
    }

    
    void EnableDoorInteraction()
    {
        DoorInteraction door = Object.FindFirstObjectByType<DoorInteraction>();
        if (door != null)
        {
            door.CanLoadEndingScene = true;
        }
    }
}
