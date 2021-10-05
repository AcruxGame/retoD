using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    System.Action<bool> callback;
    [SerializeField] float movementSpeed;

    Vector2 dirVector;

    bool isMoving;

    public bool IsMoving { get => isMoving; private set => isMoving = value; }
    public Vector2 DirVector { get => dirVector;private set => dirVector = value; }

    public void GetReferences(System.Action<bool> call)
    {
        callback = call;
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.velocity = dirVector * movementSpeed * Time.fixedDeltaTime;
    }

    private void OnDisable()
    {
        rb.velocity = Vector2.zero;
    }

    public void Move(Vector2 vector)
    {
        dirVector = vector;
        isMoving = dirVector != Vector2.zero;
        callback(isMoving);
    }

}
