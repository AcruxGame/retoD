using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorManager : MonoBehaviour
{
    Animator anim;

    bool isMoving;
    Vector2 playerDirectionVector;
    public bool IsMoving { get => isMoving; set => isMoving = value; }
    public Vector2 PlayerDirectionVector { get => playerDirectionVector; set => playerDirectionVector = value; }

    public void GetReferences(Animator playerAnim)
    {
        anim = playerAnim;
    }



    public void UpdateBooleans()
    {
        anim.SetBool("isWalking", isMoving);
    }

    public void UpdateValues()
    {
        if(Mathf.Abs(playerDirectionVector.x) == 1)
        {
            anim.SetFloat("Direction", 1);
            anim.SetFloat("FacinDirection", 1);

            if(playerDirectionVector.x == -1)//flip
            {
                transform.localScale = new Vector3(1, 1, 1);
            }else if (playerDirectionVector.x == 1)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
        }
        else if(playerDirectionVector.y == 1 && playerDirectionVector.x == 0)
        {
            anim.SetFloat("Direction", 2);
            anim.SetFloat("FacinDirection", 2);
        }
        else if (playerDirectionVector.y == -1 && playerDirectionVector.x == 0)
        {
            anim.SetFloat("Direction", 0);
            anim.SetFloat("FacinDirection", 0);
        }


    }
}
