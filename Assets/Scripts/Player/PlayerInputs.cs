using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputs : MonoBehaviour
{
    PlayerMovement movement;
    PlayerInteract interact;
    Resonator resonator;
    public void GetReferences(PlayerMovement playerMovement, PlayerInteract playerInteract, Resonator playerResonator)
    {
        movement = playerMovement;
        interact = playerInteract;
        resonator = playerResonator;
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

    public void ResonatorInteraction(InputAction.CallbackContext context)
    {
       if(context.started) resonator.ResonatorSwitch();
    }
}
