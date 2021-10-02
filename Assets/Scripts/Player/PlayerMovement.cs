using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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

    private void FixedUpdate()
    {
        rb.velocity = dirVector * movementSpeed * Time.fixedDeltaTime;
    }

    public void Move(Vector2 vector)
    {
        dirVector = vector;
    }

}
