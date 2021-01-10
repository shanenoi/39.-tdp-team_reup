using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pianoGame : MonoBehaviour
{
    public GameObject interactBtn;
    public GameObject animator;
    public GameObject effect;

    public void activeToggle()
    {
        if(gameObject.active == true)
        {
            gameObject.SetActive(false);
        }
        else gameObject.SetActive(true);
    }
    public void playCutScene()
    {
        animator.SetActive(true);
        effect.SetActive(true);
        StartCoroutine(FinishCut());
    }
    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(1);
        animator.SetActive(false);
        effect.SetActive(false);
    }
}
