using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCode : MonoBehaviour
{
    public Button button;
    public KeyCode key;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            button.onClick.Invoke();
        }
    }
}
