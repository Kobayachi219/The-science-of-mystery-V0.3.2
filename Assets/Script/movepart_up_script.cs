using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movepart_up_script : MonoBehaviour
{
    public Rigidbody2D Rigidbody2D;
    [SerializeField] private float fixGravityScale = 50f;
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.CompareTag("Player")) 
        {
            Rigidbody2D.gravityScale = fixGravityScale;
        }
    }
    
}
