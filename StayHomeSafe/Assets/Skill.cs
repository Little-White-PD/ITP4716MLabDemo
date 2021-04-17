using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{
    public GameObject skillColl;
    public bool skillCD;
    public PlayerController playerController;
    public ConvertToInfector convertToInfector;

    private void Start()
    {
        playerController = GetComponentInParent<PlayerController>();
        convertToInfector = GetComponentInParent<ConvertToInfector>();
    }

    private void Update()
    {
        if (skillCD == false && convertToInfector.sleep == false)
        {
            if (Input.GetKeyDown(playerController.skill))
            {
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
