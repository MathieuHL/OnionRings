using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectiblesScript : MonoBehaviour
{
    private GameObject player;
    public static float score;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Destroy brocolis if hit object with Border tag
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        else if(collision.tag == "Player")
        {
            Destroy(this.gameObject);
            score += 1 + 5 * Time.deltaTime;
        }
    }
}
