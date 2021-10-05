using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour
{
    public static bool minijuego1Completado;
    public static bool minijuego2Completado;



    public static void Juego1Terminado()
    {
        minijuego1Completado = true;

        if (minijuego2Completado)
        {
            DayCycle.SetNight();
        }
    }

    public static void Juego2Terminado()
    {
        minijuego2Completado = true;


        if (minijuego1Completado)
        {
            DayCycle.SetNight();
        }
    }

    public static void ResetGames()
    {
        minijuego1Completado = false;
        minijuego2Completado = false;
    }
}
