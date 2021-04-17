using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatGuySkill : MonoBehaviour
{
    public PlayerController playerController;
    public ConvertToInfector convertToInfector;
    public bool skillCD;
    public GameObject bike;

    public AudioSource source;
    public AudioClip useSkill;
    public AudioClip hit;
    public AudioClip wakeUp;

    void Start()
    {
        playerController = GetComponentInParent<PlayerController>();
        convertToInfector = GetComponentInParent<ConvertToInfector>();
    }

    
    void Update()
    {
        if (skillCD == false && convertToInfector.sleep == false)
        {
            if (Input.GetKeyDown(playerController.skill))
            {
                skillCD = true;
                bike.SetActive(true);
                transform.position += new Vector3(0,0.3f,0);
                playerController.speed = 7f;
            }
        }
    }

    public void Hit()
    {
        bike.SetActive(false);
        transform.position -= new Vector3(0, 0.3f, 0);
        convertToInfector.sleep = true;
        StartCoroutine(SkillCD());
        StartCoroutine(Wake());
    }

    IEnumerator SkillCD()
    {
        yield return new WaitForSeconds(40);
        skillCD = false;
    }

    IEnumerator Wake()
    {
        yield return new WaitForSeconds(5);
        source.PlayOneShot(wakeUp);
    }
}
