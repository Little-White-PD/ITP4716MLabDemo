using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction direction;
    public CharacterController controller;
    public float speed;

    Animator anim;
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        direction.Enable();
    }

    private void OnDisable()
    {
        direction.Disable();
    }

    private void FixedUpdate()
    {
        Vector2 inputVector = direction.ReadValue<Vector2>();
        Vector3 finalVector = new Vector3();
        finalVector.x = inputVector.x;
        finalVector.z = inputVector.y;
        controller.Move(finalVector * Time.deltaTime * speed);
        if (finalVector != Vector3.zero)
        {
            gameObject.transform.forward = finalVector;
        }
        anim.SetFloat("speed", inputVector.magnitude);
    }
}
