using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Singleton<PlayerController>
{
    PlayerInputs pInputs;
    PlayerMovement movement;
    PlayerInteract interaction;
    Resonator resonator;

    public override void Awake()
    {
        base.Awake();
        pInputs = GetComponent<PlayerInputs>();
        movement = GetComponent<PlayerMovement>();
        interaction = GetComponent<PlayerInteract>();
        resonator = GetComponent<Resonator>();
    }

    private void Start()
    {
        pInputs.GetReferences(movement, interaction, resonator);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
