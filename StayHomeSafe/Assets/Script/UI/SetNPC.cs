using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetNPC : MonoBehaviour
{
    private float input;
    public void Set1(float s)
    {
        PlayerPrefs.SetFloat("NPCr1", s);
        input = s;
    }
    public void Set2(float x)
    {
        PlayerPrefs.SetFloat("NPCr2", x);
        input = x;
    }
}
