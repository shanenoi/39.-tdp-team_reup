using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetLetter : MonoBehaviour
{
    public GameObject player;
    public GameObject faker_player;
    public GameObject ghe;
    public GameObject faker_ghe;
    public GameObject animator;
    public GameObject message;
    public GameObject news;
    float original_speed;
    bool first_time = true;


    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (first_time)
        {
            if (collision.tag == "Player")
            {
                message.SetActive(true);
            }
            else
            {
                if (collision.tag == "ghe")
                {
                    original_speed = player.GetComponent<BoyController>().speed;
                    player.GetComponent<BoyController>().speed = 0;
                    player.SetActive(false);
                    ghe.SetActive(false);
                    animator.SetActive(true);
                    StartCoroutine(FinishCut());
                    player.GetComponent<BoyController>().speed = original_speed;
                    first_time = false;
                }
            }
        }
    }
    IEnumerator FinishCut()
    {
        news.SetActive(true);
        yield return new WaitForSeconds(5);
        news.SetActive(false);
        animator.SetActive(false);
        player.SetActive(true);
        ghe.SetActive(false);

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        message.SetActive(false);
    }
}
