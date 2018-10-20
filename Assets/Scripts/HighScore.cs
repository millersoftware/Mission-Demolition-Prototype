using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {
    static public int score = 1000;
    public float time = 0.0f;
    public int level = 0;
	// Use this for initialization
	void Awake () {
        if (PlayerPrefs.HasKey("High Score"))
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
        time = Time.time;
        if (level != MissionDemolition.getLevel())
        {
            score = 1000;
        }
        Text gt = this.GetComponent<Text>();
        gt.text = "Score lvl " + MissionDemolition.getLevel() + ": " + (score - (int)time);

        if (score > PlayerPrefs.GetInt(MissionDemolition.getLevel() +"HighScore"))
        {
            PlayerPrefs.SetInt(MissionDemolition.getLevel() + "HighScore", score - (int)time);
        }
	}
}
