using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesOJ : MonoBehaviour
{
    public Collider coll;

    private void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall")
            Destroy(gameObject);

    }
}
