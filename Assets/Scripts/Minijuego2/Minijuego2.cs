using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minijuego2 : MonoBehaviour, IInteractable
{
    [SerializeField] GameObject notas;
    public static bool notasRecogidas;
    public void Interact()
    {
        if (!Status.minijuego2Completado)
        {
            notas.SetActive(false);
            notasRecogidas = true;
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        if (Status.minijuego2Completado)
        {
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
