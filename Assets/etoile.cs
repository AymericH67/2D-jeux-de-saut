using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class etoile : MonoBehaviour
{
    public int etoileValue = 1;
    public Scene scene;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            scene.nombreEtoile ++;
            Destroy(gameObject);
        }
    }
}
