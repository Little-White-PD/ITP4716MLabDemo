using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vol : MonoBehaviour
{
    public AudioSource AudioSource;
    public float musicVol;
    void Start()
    {
        musicVol = PlayerPrefs.GetFloat("BackgroundPref");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
