using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    int dinero;

    public int Dinero { get => dinero;private set => dinero = value; }

    public void AddCash(int amount)
    {
        dinero += amount;
    }
}
