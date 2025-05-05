using UnityEngine;

public class BackgroundMusicManager : MonoBehaviour
{
    public AudioSource backgroundMusicSource;
    public AudioClip backgroundMusicClip;

    private static BackgroundMusicManager instance;

    void Awake()
    {
        // Check if another instance of BackgroundMusicManager exists
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);  // Makes this object persist across scenes
        }
        else
        {
            Destroy(gameObject);  // Destroy this object if there's already a manager
        }
    }

    void Start()
    {
        if (backgroundMusicSource != null && backgroundMusicClip != null)
        {
            backgroundMusicSource.clip = backgroundMusicClip;
            backgroundMusicSource.Play();  // Start playing background music
        }
    }

    public void ChangeMusic(AudioClip newClip)
    {
        if (backgroundMusicSource != null)
        {
            backgroundMusicSource.clip = newClip;
            backgroundMusicSource.Play();
        }
    }
}
