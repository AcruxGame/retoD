using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractMessage : MonoBehaviour
{
    [SerializeField] Image interactMessage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        interactMessage.gameObject.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        interactMessage.gameObject.SetActive(false);
    }
}
