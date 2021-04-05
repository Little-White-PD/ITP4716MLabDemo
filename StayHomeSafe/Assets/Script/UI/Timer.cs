using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public float myTimer;
	public GameObject Gameover;

	Text text;

	void Start () {
		text = GetComponent<Text>();
		myTimer = PlayerPrefs.GetFloat("Time");
		
	}

	void Update () {
		if (myTimer > 0)
			myTimer -= Time.deltaTime;
		else {
			myTimer = 0;
		}
		text.text = (myTimer).ToString("00");

		if(myTimer <= 10 && myTimer >= 0)
        {
			text.color = Color.red;
        }

		if(myTimer <= 0)
        {
			Time.timeScale = 0;
			Gameover.SetActive(true);
			text.enabled = false;
        }
	}
}


