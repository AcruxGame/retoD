using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    bool interacting;
    bool interacted;
    public void EnableInteract()
    {
        interacting = true;
    }
    public void DisableInteract()
    {
        interacting = false;
        interacted = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Interactuable") && interacting && !interacted) 
        {

            Debug.Log("Interactuando");
            interacted = true;
        }
    }
}
