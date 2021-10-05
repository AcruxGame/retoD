using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class M2Movement : MonoBehaviour
{
    [SerializeField] ChangeStatus cubo1;
    [SerializeField] ChangeStatus cubo2;
    [SerializeField] ChangeStatus cubo3;
    [SerializeField] Button exitButton;

    Vector2 dirVector;
    Rigidbody2D rb;
    [SerializeField] float movementSpeed;
    public Vector2 DirVector { get => dirVector; private set => dirVector = value; }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        exitButton.gameObject.SetActive(false);
    }

    private void FixedUpdate()
    {
        rb.velocity = dirVector * movementSpeed * Time.fixedDeltaTime;


        if(cubo1.activated && cubo2.activated && cubo3.activated)
        {
            exitButton.gameObject.SetActive(true);
        }
    }

    public void Move(InputAction.CallbackContext context)
    {
        dirVector = context.ReadValue<Vector2>();
    }

    public void Regresar()
    {
        SceneManager.LoadScene("Industria");
    }

}
