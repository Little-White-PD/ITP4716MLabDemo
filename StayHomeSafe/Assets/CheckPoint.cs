using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public GameObject[] checkPoint;
    public Collider coll;
    // Start is called before the first frame update

    private void Start()
    {
        coll = GetComponent<Collider>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            checkPoint[0].SetActive(true);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "location3")
        {
            checkPoint[0].SetActive(false);
        }
    }
}
