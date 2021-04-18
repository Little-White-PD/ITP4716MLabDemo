using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    public InputAction direction;
    public CharacterController controller;
    public AnimatorHandler animatorHandler;
    public ConvertToInfector convertToInfector;

    public Vector3 finalVector;
    public float speed;
    public float rotationSpeed = 10f;
    private float gravityValue = -9.81f;

    Animator anim;
    public KeyCode skill;

    private void Awake()
    {

    }
    private void Start()
    {
        controller = GetComponentInChildren<CharacterController>();
        anim = GetComponentInChildren<Animator>();
        animatorHandler = GetComponentInChildren<AnimatorHandler>();
        animatorHandler.Initialize();
        convertToInfector = GetComponent<ConvertToInfector>();

    }

    private void OnEnable()
    {
        direction.Enable();
    }

    private void OnDisable()
    {
        direction.Disable();
    }

    private void Update()
    {

        Vector2 inputVector = direction.ReadValue<Vector2>();

        finalVector.x = inputVector.x;
        finalVector.z = inputVector.y;
        finalVector.y += gravityValue * Time.deltaTime;
        if (convertToInfector.sleep == false)
        {
            if (convertToInfector.usingSkill == false)
            {
                controller.Move(finalVector * Time.deltaTime * speed);

                if (animatorHandler.canRotate)
                {

                    finalVector.Normalize();
                    finalVector.y = 0;

                    if (finalVector == Vector3.zero)
                        finalVector = gameObject.transform.forward;

                    float rs = rotationSpeed;

                    Quaternion tr = Quaternion.LookRotation(finalVector);
                    Quaternion targetRotation = Quaternion.Slerp(gameObject.transform.rotation, tr, rs * Time.deltaTime);

                    gameObject.transform.rotation = targetRotation;
                }
                anim.SetFloat("speed", inputVector.magnitude);
            }

        }
        else finalVector = new Vector3(0, 0, 0);

    }
}

