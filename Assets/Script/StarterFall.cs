using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarterFall : MonoBehaviour
{
    public Animator Animator;
    void Start()
    {
        Animator.SetBool("isJumping", true);
    }

  
}
