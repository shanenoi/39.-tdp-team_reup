using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutsceneoutside : MonoBehaviour
{
    public GameObject player;
    public GameObject animator;
    public GameObject button;
    public GameObject effect;


    public GameObject hiddenObj1;
    public GameObject hiddenObj2;


    public float animationDuration = 0;
    float original_speed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        button.SetActive(true);
        original_speed = player.GetComponent<BoyController>().speed;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        button.SetActive(false);
    }
    public void beginCutScene()
    {
        Debug.Log("a");
        hiddenObj1.SetActive(false);
        hiddenObj2.SetActive(false);
        effect.SetActive(true);
        animator.SetActive(true);
        player.GetComponent<BoyController>().speed = 0;
        StartCoroutine(FinishCut());
    }
    IEnumerator FinishCut()
    {

        yield return new WaitForSeconds(animationDuration);
        player.GetComponent<BoyController>().speed = original_speed;
        animator.SetActive(false);
        effect.SetActive(false);
        hiddenObj1.SetActive(true);
        hiddenObj2.SetActive(true);
        Debug.Log("b");
    }
}
