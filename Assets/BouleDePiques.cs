using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouleDePiques : MonoBehaviour
{
    public GameObject player;
    public Player playerScript;
    public float degats;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            playerScript.health -= degats;
        }
    }
}

