using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PastNight : MonoBehaviour
{
    Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void NextDay()
    {
        Debug.Log("Pasando la noche");
        anim.Play("PastNight");
        DayCycle.SetDay();
    }
}
