using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ConvertToInfector : MonoBehaviour
{
    [Header("PlayerState")]
    public bool HaveBuff;
    public bool sleep;
    public bool usingSkill;
    public bool protect;
    public float protectTime;
    public float playerPoint;
    public float skillTime;

    [Header("Slot")]
    public bool mask;
    public bool gasMask;
    public bool useSyringe;
    [Header("Effect")]
    public ParticleSystem buff;
    public ParticleSystem protection;
    public ParticleSystem heal;

    [Header("Script")]
    public float gasMaskTime = 20f;
    public float maskTime = 5f;

    public CapsuleCollider collider;
    public PlayerController playerController;
    public Animator anim;

    private Inventory inventory;
    public TextMeshProUGUI text;
    public TextMeshProUGUI skillTimer;

    private void Awake()
    {
        inventory = GetComponent<Inventory>();

        buff.Play();
    }

    public void Start()
    {
        collider = GetComponent<CapsuleCollider>();
        anim = GetComponentInChildren<Animator>();
        heal.Stop();
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
        if (protect == false)
        {
            protection.Stop();
        }

        else if (protect == true && !protection.isPlaying)
        {
            protection.Play();
        }

        if (protectTime > 0)
        {
            protect = true;
            protectTime -= Time.deltaTime;

        }
        else
        {
            protect = false;
        }
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

        if (usingSkill)
        {
            anim.SetBool("skill", true);
            StartCoroutine(Skilling());
        }

        text.text = (playerPoint).ToString("00");
        skillTimer.text = (skillTime).ToString("00");

        if (skillTime > 0)
        {
            skillTime -= Time.deltaTime;
        }

    }

    public void OnTriggerStay(Collider other)
    {
        ConvertToInfector convert = other.GetComponent<ConvertToInfector>();
        if (HaveBuff == true && protect == false)
        {
            if (convert.protect == false)
            {
                convert.HaveBuff = true;


            }
        }

        if (useSyringe == true && other.tag == "NPC")
        {
            if (HaveBuff == true)
            {
                HaveBuff = false;
                useSyringe = false;
            }
            else if (convert.HaveBuff == true)
            {
                useSyringe = false;
                playerPoint += 10f;
                heal.Play();
                Destroy(convert.gameObject);
            }
            else
            {
                useSyringe = false;
                playerPoint += 5f;
                heal.Play();
                Destroy(convert.gameObject);
            }
            PlayerPrefs.SetFloat("PlayerPoint", playerPoint);

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

    IEnumerator Skilling()
    {
        yield return new WaitForSeconds(2);
        anim.SetBool("skill", false);
        usingSkill = false;

    }





}

