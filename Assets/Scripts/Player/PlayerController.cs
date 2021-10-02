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
    bool canMove = true;

    public override void Awake()
    {
        base.Awake();
        pInputs = GetComponent<PlayerInputs>();
        movement = GetComponent<PlayerMovement>();
        interaction = GetComponent<PlayerInteract>();
        resonator = GetComponent<Resonator>();
        inventory = GetComponent<InventoryManager>();
    }


    private void Start()
    {
        pInputs.GetReferences(movement, interaction, resonator, inventory);
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

}
