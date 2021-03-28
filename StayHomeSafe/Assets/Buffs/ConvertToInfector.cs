using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertToInfector : MonoBehaviour
{

    public GameObject citizen;
    public Collider collider;

    public void Start()
    {
        if (citizen.tag == "Infector")
            collider.enabled = !collider.enabled;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Infector" && citizen.tag != "Infector")
        {
            citizen.tag = "Infector";
            collider.enabled = !collider.enabled;
        }
    }
}