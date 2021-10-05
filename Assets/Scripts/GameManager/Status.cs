using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour
{
    public static bool minijuego1Completado;
    public static bool minijuego2Completado;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public static void Juego1Terminado()
    {
        minijuego1Completado = true;
    }

    public static void Juego2Terminado()
    {
        minijuego2Completado = true;
    }

    public void ResetGames()
    {
        minijuego1Completado = false;
        minijuego2Completado = false;
    }
}
