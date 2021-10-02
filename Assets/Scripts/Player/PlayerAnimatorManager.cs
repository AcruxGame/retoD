using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorManager : MonoBehaviour
{
    Animator anim;

    bool isMoving;

    public bool IsMoving { get => isMoving; set => isMoving = value; }

    public void GetReferences(Animator playerAnim)
    {
        anim = playerAnim;
    }


    void Update()
    {
        anim.SetBool("isWalking", isMoving);
    }
}
