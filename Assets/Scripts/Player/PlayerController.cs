using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Singleton<PlayerController>
{
    PlayerInputs pInputs;
    PlayerMovement movement;
    PlayerInteract interaction;
    Resonator resonator;
    InventoryManager inventory;
    PlayerAnimatorManager playerAnim;
    Animator anim;
    SpriteRenderer sRenderer;
    [SerializeField] Color nightColor;
    bool canMove = true;

    public override void Awake()
    {
        base.Awake();
        pInputs = GetComponent<PlayerInputs>();
        movement = GetComponent<PlayerMovement>();
        interaction = GetComponent<PlayerInteract>();
        resonator = GetComponent<Resonator>();
        inventory = GetComponent<InventoryManager>();
        playerAnim = GetComponent<PlayerAnimatorManager>();
        anim = GetComponent<Animator>();
        sRenderer = GetComponent<SpriteRenderer>();
    }


    private void Start()
    {
        pInputs.GetReferences(movement, interaction, resonator, inventory);
        playerAnim.GetReferences(anim);
        movement.GetReferences(ReadMovingState);
        inventory.inventoryHandler += CanMoveSwitch;
        DayCycle.TimeHandler += UpdateColors;
    }

    private void CanMoveSwitch() {
        canMove = !inventory.Inventory.activeSelf;
        movement.enabled = canMove;
    }

    private void ReadMovingState(bool status)
    {
        playerAnim.IsMoving = status;
        playerAnim.UpdateBooleans();
        playerAnim.PlayerDirectionVector = movement.DirVector;
        playerAnim.UpdateValues();
    }

    private void UpdateColors()
    {
        if (DayCycle.ItIsDay)
        {
            sRenderer.color = Color.white;
        }
        else
        {
            sRenderer.color = nightColor;
        }

    }

}
