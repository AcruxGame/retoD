using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resonator : MonoBehaviour
{
    bool resonatorOn;
    public void ResonatorSwitch()
    {
        resonatorOn = !resonatorOn;
        Debug.Log(resonatorOn);
    }
}
