using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Config : Singleton<Config>
{

    public override void Awake()
    {
        base.Awake();
    }

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 80;//limita el framerate a 80 fps
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
