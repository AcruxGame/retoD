using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputs : MonoBehaviour
{
    PlayerMovement movement;
    PlayerInteract interact;
    public void GetReferences(PlayerMovement playerMovement, PlayerInteract playerInteract)
    {
        movement = playerMovement;
        interact = playerInteract;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MovementInput(InputAction.CallbackContext context)
    {
        movement.Move(context.ReadValue<Vector2>());
    }

    public void InteractInput(InputAction.CallbackContext context)
    {
        if (context.started) interact.EnableInteract();

        if (context.canceled) interact.DisableInteract();
    }
}
