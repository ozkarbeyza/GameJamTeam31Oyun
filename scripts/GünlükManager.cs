using UnityEngine;
using UnityEngine.UI;

public class GünlükManager : MonoBehaviour
{
    public Sprite[] pageSprites;
    public Image pageDisplay;
    public Button nextButton;
    public Button prevButton;
    public Button closeButton;
    public GameObject diaryPanel;
    public AudioSource gunlukSesKaynagi;
    public AudioClip acilisSesi;
    public AudioClip kapanisSesi;
    public AudioSource sayfaCevirmeSesKaynagi;
    public AudioClip sayfaCevirmeSesi;

    private int currentPage = 0;

    void Start()
    {
        ShowPage(currentPage);

        nextButton.onClick.AddListener(NextPage);
        prevButton.onClick.AddListener(PreviousPage);
        closeButton.onClick.AddListener(CloseDiary);
    }

    void ShowPage(int index)
    {
        pageDisplay.sprite = pageSprites[index];
        prevButton.interactable = index > 0;
        nextButton.interactable = index < pageSprites.Length - 1;
    }
    public void OpenDiary()
    {
        diaryPanel.SetActive(true);

        
        if (gunlukSesKaynagi != null && acilisSesi != null)
        {
            gunlukSesKaynagi.PlayOneShot(acilisSesi);
        }

        ShowPage(currentPage);
    }

    public void NextPage()
    {
        if (currentPage < pageSprites.Length - 1)
        {
            currentPage++;
            ShowPage(currentPage);
            PlayPageFlipSound();
        }
    }

    public void PreviousPage()
    {
        if (currentPage > 0)
        {
            currentPage--;
            ShowPage(currentPage);
            PlayPageFlipSound();
        }
    }

    public void CloseDiary()
    {
        // Play closing sound
        if (gunlukSesKaynagi != null && kapanisSesi != null)
        {
            gunlukSesKaynagi.clip = kapanisSesi;
            gunlukSesKaynagi.Play();
        }

        diaryPanel.SetActive(false);
    }

    void PlayPageFlipSound()
    {
        if (sayfaCevirmeSesKaynagi != null && sayfaCevirmeSesi != null)
        {
            sayfaCevirmeSesKaynagi.PlayOneShot(sayfaCevirmeSesi);
        }
    }
}
