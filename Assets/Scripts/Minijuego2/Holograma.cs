using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Olograma : MonoBehaviour,IInteractable
{
    GameObject collSecundario;
    private void Start()
    {
        if (Status.minijuego2Completado)
        {
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
    public void Interact()
    {
        
    }

    [SerializeField] Image interactMessage;
    [SerializeField] Image error;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && Minijuego2.notasRecogidas)
        {
            interactMessage.gameObject.SetActive(true);
        }
        else if(collision.CompareTag("Player") && !Minijuego2.notasRecogidas)
        {
            error.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) interactMessage.gameObject.SetActive(false);
        if (collision.CompareTag("Player")) error.gameObject.SetActive(false);
    }
}
