using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoAfraid : MonoBehaviour
{

    public float speed = 4f;
    public PlayerController playerController;
    public ConvertToInfector convertToInfector;
    public bool skillCD;
    public bool useSkill;

    public AudioSource source;

    public AudioClip eatShitDog;

    public GameObject sleep;


    void Start()
    {
        playerController = GetComponentInParent<PlayerController>();
        convertToInfector = GetComponentInParent<ConvertToInfector>();
        source = GetComponent<AudioSource>();
        playerController.speed = 4f;

    }

    void Update()
    {
        if (skillCD == false && convertToInfector.sleep == false)
        {
            if (Input.GetKeyDown(playerController.skill))
            {
                
                source.PlayOneShot(eatShitDog);
                skillCD = true;
                sleep.SetActive(true);
                playerController.speed = 10f;
                StartCoroutine(SkillTime());
            }
        }
    }

    IEnumerator SkillTime()
    {
        yield return new WaitForSeconds(10f);
        playerController.speed = 4f;
        convertToInfector.skillTime = 20f;
        sleep.SetActive(false);
        StartCoroutine(SkillCD());
    }

    IEnumerator SkillCD()
    {
        yield return new WaitForSeconds(20f);
        skillCD = false;
    }
    
}
