using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            PlayerPrefs.SetInt((string)i + "HighScore", score);
        }
	}
	
	// Update is called once per frame
	void Update () {
		if(score > PlayerPrefa.GetInt((string)MissionDemolition.level +"HighScore"))
        {
            PlayerPrefs.SetInt((string)MissionDemolition.level + "HighScore", score);
        }
	}
}
