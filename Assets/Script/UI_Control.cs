using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UI_Contorll : MonoBehaviour
{
    [SerializeField] private Image ChapterTitle;
    [SerializeField] private float delay;
    void Start()
    {
        StartCoroutine(DelayTimeTitle());
    }

  IEnumerator DelayTimeTitle()
    {
        yield return new WaitForSeconds(delay   );
        ChapterTitle.gameObject.SetActive(false);
    }
}
