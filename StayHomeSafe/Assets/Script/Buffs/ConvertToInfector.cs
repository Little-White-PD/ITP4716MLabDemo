using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ConvertToInfector : MonoBehaviour
{
    public CapsuleCollider collider;
    public PlayerController playerController;
    public Animator anim;
    public bool HaveBuff;
    public bool sleep;
    public ParticleSystem buff;
    private Inventory inventory;
    public TextMeshProUGUI text;

    public float gasMaskTime = 20f;
    public float maskTime = 5f;

    public bool mask;
    public bool gasMask;
    public bool useSyringe;

    public float protectTime;
    public bool protect;

    public float playerPoint;

    private void Awake()
    {
        inventory = GetComponent<Inventory>();
        
        buff.Play();
    }

    public void Start()
    {
        collider = GetComponent<CapsuleCollider>();
        anim = GetComponentInChildren<Animator>();
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

        if (useSyringe == true)
        {
            HaveBuff = false;
        }
        if (HaveBuff == false)
        {
            useSyringe = false;
        }

        if (sleep)
        {
            anim.SetBool("sleep", true);
            StartCoroutine(Sleep());
        }

        text.text = (playerPoint).ToString("00");

    }

    public void OnTriggerStay(Collider other)
    {
        ConvertToInfector convert = other.GetComponent<ConvertToInfector>();
        if (HaveBuff == true && protect == false)
        {
            if (convert.protect == false )
            {
                convert.HaveBuff = true;
                               

            }
        }
        if (useSyringe == true && other.tag == "NPC")
        {
            if (convert.HaveBuff == true)
            {
                useSyringe = false;
                playerPoint += 10f;
                Destroy(convert.gameObject);
            }
            else 
            {
                useSyringe = false;
                playerPoint += 5f;
                Destroy(convert.gameObject);
            }

        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "sleep")
            sleep = true;
    }

    IEnumerator Sleep()
    {
        yield return new WaitForSeconds(5);
        anim.SetBool("sleep", false);
        sleep = false;

    }


    


}

