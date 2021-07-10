using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chack : MonoBehaviour
{
    public GameObject[] item;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        { 
            item[0].SetActive(false);
            item[1].SetActive(true);
            item[2].SetActive(true);
        }
        
    }
}
