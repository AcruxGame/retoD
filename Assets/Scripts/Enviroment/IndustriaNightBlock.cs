using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndustriaNightBlock : MonoBehaviour
{
    Salida salida;

    private void Awake()
    {
        salida = GetComponentInChildren<Salida>();
        DayCycle.TimeHandler += UpdateTime;
    }

    private void Start()
    {
        UpdateTime();
    }

    private void UpdateTime()
    {
        salida.gameObject.SetActive(DayCycle.ItIsDay);
    }
}
