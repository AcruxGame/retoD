using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CuartoAna : MonoBehaviour
{
    SpriteRenderer sRenderer;
    [SerializeField] Sprite day;
    [SerializeField] Sprite night;
    private void Awake()
    {
        sRenderer = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        DayCycle.TimeHandler += UpdateRoom;
        UpdateRoom();
    }
    private void OnDisable()
    {
        DayCycle.TimeHandler -= UpdateRoom;
    }

    private void UpdateRoom()
    {
        if (DayCycle.ItIsDay)
        {
            sRenderer.sprite = day;
        }
        else
        {
            sRenderer.sprite = night;
        }
    }
   
}
