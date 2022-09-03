using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemis : MonoBehaviour
{
    public float speed;
    public float degats;
    public bool toRight;

    public Player player;
    public GameObject spawn;

    public Rigidbody2D rb;

    private void Start()
    {
        if(toRight == true)
        {
            rb.AddForce(new Vector2(speed, 0));
        }
        else if(toRight == false)
        {
            rb.AddForce(new Vector2(-speed, 0));
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
       if(col.tag == "endEmpty")
       {
            gameObject.transform.position = spawn.transform.position;
       } 

       if(col.name == "Player")
       {
            player.health -= degats;
       }
    }
}
