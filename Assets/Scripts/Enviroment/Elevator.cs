using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Elevator : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        SceneManager.LoadScene("Cuarto_Ana");
    }

    
}
