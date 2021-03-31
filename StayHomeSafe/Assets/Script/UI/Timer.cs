using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public float myTimer=10;

	Text text;

	void Start () {
		text = GetComponent<Text>();
	}

	void Update () {
		if (myTimer > 0)
			myTimer -= Time.deltaTime;
		else {
			myTimer = 0;
		}
		text.text = (myTimer).ToString("00");
	}
}


