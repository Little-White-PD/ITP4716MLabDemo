using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    public int countdownTimer;
    public Text text;
    public GameObject Timer;


    private void Start()
    {
        StartCoroutine(CountdownToStart());
    }
    IEnumerator CountdownToStart()
    {
        while(countdownTimer > 0)
        {
            text.text = (countdownTimer).ToString("00");

            yield return new WaitForSeconds(1f);

            countdownTimer--;
        }

        //text = "Start!";

        yield return new WaitForSeconds(1f);

        text.enabled = false;

        if(countdownTimer < 0)
        {
            Timer.SetActive(true);
        }
    }
}