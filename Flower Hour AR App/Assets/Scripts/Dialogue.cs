using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct Line
{
    public Sprite lillian;
    public AudioClip audio;

    [TextArea(3, 20)]
    public string sentence;
}

[CreateAssetMenu(fileName = "New Dialogue", menuName = "Dialogue")]
public class Dialogue : ScriptableObject
{
    public Image lillian;
    public AudioClip audio;
    public Line[] lines;

    //public Image lillian;

    //[TextArea(3, 20)]
    //public string[] sentences;
}
