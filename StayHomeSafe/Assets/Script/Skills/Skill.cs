using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{
    public float speed = 5f;
    public GameObject skillColl;
    public bool skillCD;
    public AudioSource source;
    public AudioClip useSkill;
    public PlayerController playerController;
    public ConvertToInfector convertToInfector;

    private void Start()
    {
        
        playerController = GetComponentInParent<PlayerController>();
        convertToInfector = GetComponentInParent<ConvertToInfector>();
        source = GetComponent<AudioSource>();
        playerController.speed = 5f;
    }

    private void Update()
    {
        if (skillCD == false && convertToInfector.sleep == false)
        {
            if (Input.GetKeyDown(playerController.skill))
            {
                source.PlayOneShot(useSkill);
                skillCD = true;
                skillColl.SetActive(true);
                convertToInfector.skillTime = 20f;
                StartCoroutine(skillCollTime());
                StartCoroutine(SkillCD());
            }
        }
    }

    IEnumerator skillCollTime()
    {
        yield return new WaitForSeconds(0.5f);
        skillColl.SetActive(false);
    }

    IEnumerator SkillCD()
    {
        yield return new WaitForSeconds(20);
        skillCD = false;
    }



}
