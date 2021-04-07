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
    public bool useSyringe;

    public float protectTime;
    public bool protect;

    private void Awake()
    {
        inventory = GetComponentInChildren<Inventory>();
        buff.Play();
    }

    public void Start()
    {


    }


    public void Update()
    {
        if (HaveBuff == false)
        {
            buff.Stop();
        }

        else if (HaveBuff == true && !buff.isPlaying)
        {
            buff.Play();
        }


        if (protectTime > 0)
        {
            protect = true;
            protectTime -= Time.deltaTime;
        }
        else protect = false;



    }

    public void OnTriggerStay(Collider other)
    {
        //if (other.tag == "Infector" && citizen.tag != "Infector" && !protect)
        if(HaveBuff == true)
        {
            if (other.GetComponent<ConvertToInfector>().protect == false)
            {
                other.GetComponent<ConvertToInfector>().HaveBuff = true;

            }
        }
        if (useSyringe == true)
        {

                other.GetComponent<ConvertToInfector>().HaveBuff = false;
                            useSyringe = false;
            
        }
        
        
    }


   /* void ColliderOpen()
    {
        if (citizen.tag == "Infector")
        {
            collider.enabled = true;
            citizen.tag = "Citizens";
        }
    }*/




}

