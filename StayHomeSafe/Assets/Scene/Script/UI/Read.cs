using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Read : MonoBehaviour
{
    private float input;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadStringInput(float s)
    {
        PlayerPrefs.SetFloat("Time", s);
        input = s;
    }
}
