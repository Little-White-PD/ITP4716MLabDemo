using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


    public class PlayerController : MonoBehaviour
    {
        public InputAction direction;
        public CharacterController controller;
        public AnimatorHandler animatorHandler;
        public PlayerInventory playerInventory;

        public Vector3 finalVector;
        public float speed;
        public float rotationSpeed = 10f;
        private float gravityValue = -9.81f;

        Animator anim;

    private void Awake()
    {
        playerInventory = GetComponent<PlayerInventory>();
    }
    private void Start()
        {
            controller = GetComponent<CharacterController>();
            anim = GetComponent<Animator>();
            animatorHandler = GetComponent<AnimatorHandler>();
            animatorHandler.Initialize();
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
        HandleQuickSlotsInput();
    }

    private void FixedUpdate()
        {
        

            Vector2 inputVector = direction.ReadValue<Vector2>();
            finalVector.x = inputVector.x;
            finalVector.z = inputVector.y;
            finalVector.y += gravityValue * Time.deltaTime;
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

    private void HandleQuickSlotsInput()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            
            playerInventory.ChangeRightWeapon();

        }
        if (Input.GetButtonDown("Fire2"))
        {

            playerInventory.ChangeLeftWeapon();
        }
    }
}

