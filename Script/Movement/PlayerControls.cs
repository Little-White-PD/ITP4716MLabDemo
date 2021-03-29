using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    public float speed = 3.14f;
    private Vector2 movementInput;   

    void Update()
    {
        transform.Translate(new Vector3(movementInput.x, 0, movementInput.y) * speed * Time.deltaTime);
    }

    public void OnAnimatorMove(InputAction.CallbackContext ctx) => movementInput = ctx.ReadValue<Vector2>();
}
