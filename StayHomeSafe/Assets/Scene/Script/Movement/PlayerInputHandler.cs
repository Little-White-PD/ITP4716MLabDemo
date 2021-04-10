using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class PlayerInputHandler : MonoBehaviour
{
    private PlayerInput playerInput;
    private Mover mover;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        var movers = FindObjectOfType<Mover>();
        var index = playerInput.playerIndex;
    }
    
    public void OnMove(CallbackContext context)
    {
        mover.SetInputVector(context.ReadValue<Vector2>());
    }
}
