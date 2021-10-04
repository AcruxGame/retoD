using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bed : MonoBehaviour, IInteractable
{
    [SerializeField]PastNight pastNight;
    [SerializeField] Image bedError;

    private void Start()
    {
        bedError.gameObject.SetActive(false);
    }
    public void Interact()
    {
        if (!DayCycle.ItIsDay)
        {
             pastNight.NextDay();
        }else
        {
            bedError.gameObject.SetActive(true);
            Invoke("CloseAdvertence", 3);
        }
    }

    void CloseAdvertence()
    {
        bedError.gameObject.SetActive(false);
    }
}
