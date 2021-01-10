using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WakeUp : MonoBehaviour
{
    public GameObject animator;
    public GameObject player;
    public float animationDuration;
    public static bool first_time = true;


    void Start()
    {
        if (!first_time)
        {
            animator.SetActive(false);
            player.SetActive(true);
        } else {
            Debug.Log("a");
            player.SetActive(false);
            animator.SetActive(true);
            StartCoroutine(FinishCut());
            first_time = false;
        }
    }
    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(animationDuration);
        animator.SetActive(false);
        player.SetActive(true);
    }
}
