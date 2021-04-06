using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ConvertToInfector : MonoBehaviour
{
    public GameObject citizen;
    public CapsuleCollider collider;
    public bool HaveBuff;
    public ParticleSystem buff;
    private Inventory inventory;

    public float gasMaskTime = 20f;
    public float maskTime = 5f;

    public bool mask;
    public bool gasMask;

    public float protectTime;
    public bool protect;

    private void Awake()
    {
        inventory = GetComponentInChildren<Inventory>();
    }

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
       if (protectTime > 0)
        {
            protect = true;
            protectTime -= Time.deltaTime;
        }
        else protect = false;

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Infector" && citizen.tag != "Infector" && !protect)
        {
            if (other.GetComponent<ConvertToInfector>().protect == false)
            {
                HaveBuff = true;
                citizen.tag = "Infector";
                collider.enabled = !collider.enabled;
                buff.Play();
            }
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

