using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class UperDoorPass : MonoBehaviour
{
    [SerializeField] public Sprite newSprite;
    [SerializeField] private SpriteRenderer spriteRenderer;
    
    [SerializeField] private SpriteRenderer spritedoor;
    public Behaviour ScriptA;
    public Animator animator;

    [SerializeField] private UnityEngine.UI.Image ImageInteract;
    
    

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        
    }

   
    void OnTriggerStay2D(Collider2D other)
    {

        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            ChangeSprite();
            ChangeDoor();
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
          
            ImageInteract.gameObject.SetActive(true);

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {



            ImageInteract.gameObject.SetActive(false);

        }
    }

    void ChangeSprite()
    {

        if (spriteRenderer != null && newSprite != null)
        {
            spriteRenderer.sprite = newSprite;
        }
    }
    void ChangeDoor()
    {
        animator.SetTrigger("open");
    }
   
}
