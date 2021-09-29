using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public CharacterController2D controller;

    public float runSpeed = 20f;

    float horizontalMove = 0f;


    // Update is called once per frame
    void Update() {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
    }

    // No se llama cada frame sino unas veces ajustadas por segundo
    void FixedUpdate() {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
    }
}
