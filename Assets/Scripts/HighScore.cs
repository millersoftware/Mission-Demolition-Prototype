using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {
    static public int score = 0;
	// Use this for initialization
	void Awake () {
		if(PlayerPrefs.HasKey("High Score"))
        {
            score = PlayerPrefs.GetInt("HighScore");
        }
        for (int i = 0; i < 4; i++)
        {
            PlayerPrefs.SetInt(i + "HighScore", score);
        }
	}
	
	// Update is called once per frame
	void Update () {
        Text gt = this.GetComponent<Text>();
        gt.text = "High Score lvl " + MissionDemolition.getLevel() + ": " + score;

        if (score > PlayerPrefs.GetInt(MissionDemolition.getLevel() +"HighScore"))
        {
            PlayerPrefs.SetInt(MissionDemolition.getLevel() + "HighScore", score);
        }
	}
}
