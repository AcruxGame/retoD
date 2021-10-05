using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Salida : MonoBehaviour,IInteractable
{
    [SerializeField]string sceneToLoad;

    public void Interact()
    {
        Debug.Log("Saliendo");
        SceneManager.LoadScene(sceneToLoad);
    }
}
