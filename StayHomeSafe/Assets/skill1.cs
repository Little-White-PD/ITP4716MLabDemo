using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skill1 : MonoBehaviour
{
    public PlayerController playerController;
    public ConvertToInfector convertToInfector;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponentInParent<PlayerController>();
        convertToInfector = GetComponentInParent<ConvertToInfector>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(playerController.skill))
        {
            convertToInfector.anim.SetTrigger("TurnAround");
        }
    }
}
