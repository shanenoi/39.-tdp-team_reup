// === System ===
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

// === Unity Engine ===
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoAnotherScene : MonoBehaviour
{
    // Start is called before the first frame update
    private void flash(string tag_direct)
    {
        Vector3 scene_position = GameObject.FindGameObjectWithTag(tag_direct).transform.position;
        GameObject user = GameObject.FindGameObjectWithTag("Player");
        
        user.transform.position = new Vector3(
            scene_position.x,
            scene_position.y,
            user.transform.position.z
        );
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Regex re = new Regex(@"(\w+)_Goto(\w+)");
        Match match = re.Match(gameObject.tag);
        if (match.Success)
        {
            Debug.Log(match.Groups[1].Value + "->" + match.Groups[2].Value);
            SceneManager.LoadScene(match.Groups[2].Value);
            /*this.flash(match.Groups[2].Value + "_Direct" + match.Groups[1].Value);*/
        } else
        {
            Debug.LogError("Error");
        }
    }

}
