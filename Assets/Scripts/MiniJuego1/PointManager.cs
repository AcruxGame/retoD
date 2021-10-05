using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PointManager : MonoBehaviour
{
    [SerializeField] List<GameObject> points;
    int totalPoints;
    [SerializeField] Slider wall;
    [SerializeField] Button exitButton;
    // Update is called once per frame

    private void Start()
    {
        totalPoints = points.Count;
        exitButton.gameObject.SetActive(false);
    }
    void Update()
    {
        wall.value = (float)points.Count / totalPoints;

        var ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
        //Debug.Log(Mouse.current.position.ReadValue());
        RaycastHit2D ray2 = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
        if (ray2)
        {
            if (ray2.collider.CompareTag("Point"))
            {
                points.Remove(ray2.collider.gameObject);

            }
        }

        if((float)points.Count / totalPoints == 0)
        {
            exitButton.gameObject.SetActive(true);
        }
    }

    public void Regresar()
    {
        Status.Juego1Terminado();
        SceneManager.LoadScene("Industria");
    }
}
