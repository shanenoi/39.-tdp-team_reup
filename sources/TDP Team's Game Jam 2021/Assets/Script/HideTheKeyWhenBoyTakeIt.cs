using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideTheKeyWhenBoyTakeIt : MonoBehaviour
{
    public GameObject key;
    void Start()
    {key.SetActive(!BoyController.has_key);}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        key.SetActive(!(collision.tag == "Player"));
    }
}
