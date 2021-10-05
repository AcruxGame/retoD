using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MesaDeDiseño : MonoBehaviour, IInteractable
{

    public void Interact()
    {
        if (!Status.minijuego1Completado)
        {
            SceneManager.LoadScene("Minijuego1");
        }
    }

    private void Start()
    {
        if (Status.minijuego1Completado)
        {
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }

}
