using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SetTimer : MonoBehaviour
{
    private float input;
    public void Set(float s)
    {
        PlayerPrefs.SetFloat("Time", s);
        input = s;
    }
}
