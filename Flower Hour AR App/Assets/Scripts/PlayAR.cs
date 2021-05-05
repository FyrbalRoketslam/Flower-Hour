using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAR : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene("AR_Button2");
    }

    public void PlayStory()
    {
        SceneManager.LoadScene("SeedStory");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("BadgeMenu");
        SceneManager.LoadScene("Menu", LoadSceneMode.Additive);
    }
    public void BadgeMenu()
    {
        SceneManager.LoadScene("BadgeMenu");
    }
    public void CorrectAnswer()
    {
        SceneManager.LoadScene("BadgeMenu");
        SceneManager.LoadScene("SeedComplete", LoadSceneMode.Additive);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
