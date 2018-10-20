using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetHighScore : MonoBehaviour
{
    public GameObject[] scoreArray;
    public void Start() {
        for (int i = 0; i < 4; i++)
        {
            Text gt = scoreArray[i].GetComponent<Text>();
            gt.text = "Score lvl " + i + ": " + PlayerPrefs.GetInt(i + "HighScore");
            //scoreArray[i].GetComponet<Text>() = "Score lvl " +i + ": " + PlayerPrefs.GetInt(i + "HighScore");

            //     Text gt = this.GetComponent<Text>();
            //gt.text = "Score lvl " + MissionDemolition.getLevel() + ": " + (score - (int)time);
            //PlayerPrefs.GetInt(i + "HighScore");
        }
    }
}
