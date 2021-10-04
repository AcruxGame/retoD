using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayCycle : MonoBehaviour
{
    static bool itIsDay;
    public delegate void OnTimeChanged();
    public static event OnTimeChanged TimeHandler;
    public static bool ItIsDay { get => itIsDay;private set => itIsDay = value; }

    private void Start()
    {
        SetNight();
    }


    static public void SetDay()
    {
        if (itIsDay)
        {
            Debug.Log("ya es de dia, no se puede volver de dia nuevamente");
        }
        else
        {
            itIsDay = true;
            TimeHandler.Invoke();
        }
    }

    static public void SetNight()
    {
        if (itIsDay)
        {
            Debug.Log("ya es de noche, no se puede volver de noche nuevamente");
        }
        else
        {
            itIsDay = false;
            TimeHandler.Invoke();
        }
    }
}
