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
    }


    private void Start()
    {
        pInputs.GetReferences(movement, interaction, resonator, inventory);
        playerAnim.GetReferences(anim);
        movement.GetReferences(ReadMovingState);
        inventory.inventoryHandler += CanMoveSwitch;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CanMoveSwitch() {
        canMove = !inventory.Inventory.activeSelf;
        movement.enabled = canMove;
    }

    private void ReadMovingState(bool status)
    {
        playerAnim.IsMoving = status;
    }


}
