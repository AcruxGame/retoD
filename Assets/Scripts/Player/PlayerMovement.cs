using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    
    [SerializeField] float movementSpeed;

    Vector2 dirVector;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame


    private void FixedUpdate()
    {
        rb.velocity = dirVector * movementSpeed * Time.fixedDeltaTime;
    }

    public void Move(InputAction.CallbackContext context)
    {
        dirVector = context.ReadValue<Vector2>();
    }
}
