using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skill1 : MonoBehaviour
{
    public PlayerController playerController;
    public ConvertToInfector convertToInfector;

    public bool skillCD;
    // Start is called before the first frame update
    void Start()
    {

        playerController = GetComponentInParent<PlayerController>();
        convertToInfector = GetComponentInParent<ConvertToInfector>();
    }

    // Update is called once per frame
    void Update()
    {
        if (skillCD == false)
        {
            if (Input.GetKeyDown(playerController.skill))
            {
                skillCD = true;
                convertToInfector.anim.SetTrigger("TurnAround");
                convertToInfector.skillTime = 15f;

                StartCoroutine(SkillCD());
            }
        }
    }



    IEnumerator SkillCD()
    {
        yield return new WaitForSeconds(15);
        skillCD = false;

    }




}
