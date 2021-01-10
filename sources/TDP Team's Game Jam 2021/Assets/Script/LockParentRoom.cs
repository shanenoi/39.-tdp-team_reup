using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockParentRoom : MonoBehaviour
{
    public GameObject locker;
    public GameObject message;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!BoyController.has_key)
        {
            locker.SetActive(true);
            message.SetActive(true);
        } else
        {
            locker.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        message.SetActive(false);
    }
}
