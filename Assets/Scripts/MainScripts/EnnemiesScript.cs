using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiesScript : MonoBehaviour
{
    private GameObject player;

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
            Destroy(player.gameObject);
        }
    }
}
