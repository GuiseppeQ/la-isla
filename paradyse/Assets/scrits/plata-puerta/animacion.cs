using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacion : MonoBehaviour
{
    public Animator animator;

    public void OpendDoor()
    {
        animator.SetTrigger("open");
    }
}
