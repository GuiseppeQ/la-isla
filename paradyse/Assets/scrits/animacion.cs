using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacion : MonoBehaviour
{
    public Animator animator;

    void OpendDoor()
    {
        animator.SetTrigger("open");
    }
}
