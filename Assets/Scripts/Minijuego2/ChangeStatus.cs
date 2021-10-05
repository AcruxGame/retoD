using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeStatus : MonoBehaviour
{
    [SerializeField] Sprite sta1;
    [SerializeField] Sprite sta2;
    [SerializeField] string asignedTag;
    SpriteRenderer sRenderer;
    [HideInInspector]public bool activated;
    // Start is called before the first frame update
    void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();
        sRenderer.sprite = sta1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(asignedTag))
        {
            sRenderer.sprite = sta2;
            activated = true;
        }
    }
}
