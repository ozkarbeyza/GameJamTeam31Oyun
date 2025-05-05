using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // List of interactive game objects
    public GameObject[] interactiveObjects;

    // Count of how many objects have been clicked
    private int objectsClicked = 0;

    // Define the scene name for the ending
    public string endingSceneName = "EndingScene";

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the clicked counter to 0
        objectsClicked = 0;
    }

    // Call this function when an interactive object is clicked
    public void ObjectClicked()
    {
        // Increment the count of clicked objects
        objectsClicked++;

        // Check if all objects have been clicked
        if (objectsClicked == interactiveObjects.Length)
        {
            // If so, enable the door's ability to load the ending scene
            EnableDoorInteraction();
        }
    }

    // This method enables the door interaction to load the ending scene
    void EnableDoorInteraction()
    {
        DoorInteraction door = Object.FindFirstObjectByType<DoorInteraction>();
        if (door != null)
        {
            door.CanLoadEndingScene = true;
        }
    }
}
