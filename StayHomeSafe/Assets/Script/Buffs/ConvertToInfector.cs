using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertToInfector : MonoBehaviour
{
    public GameObject citizen;
    public Collider collider;
    public bool HaveBuff;
    public ParticleSystem buff;

    public void Start()
    {
        if (citizen.tag == "Infector")
        {
            HaveBuff = true;
            collider.enabled = !collider.enabled;
            buff.Play();
        }
    }

    public void Update()
    {
        if (HaveBuff == false)
        {
            buff.Stop();
            ColliderOpen();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Infector" && citizen.tag != "Infector")
        {
            HaveBuff = true;
            citizen.tag = "Infector";
            collider.enabled = !collider.enabled;
            buff.Play();
        }
    }

    void ColliderOpen()
    {
        if (citizen.tag == "Infector")
        {
            collider.enabled = true;
            citizen.tag = "Citizens";
        }
    }
}