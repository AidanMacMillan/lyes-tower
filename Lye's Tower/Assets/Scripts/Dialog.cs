using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{  
    public int index = -1;
    public List<string> dialog = new List<string>();

    public List<Color> speaker = new List<Color>();
    public TextMeshPro text;

    public void Next() {
        index++;
        text.text = dialog[index];
        text.color = speaker[index];
    }

    public void Hide() {
        text.color = new Color(0,0,0,0);
    }
}
