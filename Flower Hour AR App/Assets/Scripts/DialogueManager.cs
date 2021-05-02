using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    public Dialogue dialogue;
    public Image lillian;
    public Text textBox;
    public Button nextButton;
    public AudioSource lineAudio;

    public string nextScene;

    private int currentDialogueLine = 0;

    // Start is called before the first frame update
    void Start()
    {
        NextDialogueLine();
    }

    public void NextDialogueLine()
    {
        if (lineAudio.isPlaying)
        {
            lineAudio.Stop();
        }

        if (currentDialogueLine < dialogue.lines.Length)
        {
            DisplayLine();
            currentDialogueLine++;
        }
        else
        {
            SceneManager.LoadScene(nextScene);
        }
    }

    private void DisplayLine()
    {
        Line line = dialogue.lines[currentDialogueLine];
        Sprite sprite = line.lillian;
        AudioClip audio = line.audio;
        string sentence = line.sentence;

        textBox.text = sentence;
        lineAudio.PlayOneShot(audio);
        lillian.sprite = sprite;
    }
}
