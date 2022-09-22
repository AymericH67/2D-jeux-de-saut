using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene : MonoBehaviour
{
    public int Level;
    public int nombreEtoile;

    public GameObject etoile1;
    public GameObject etoile2;
    public GameObject etoile3;
    public GameObject etoile0;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (nombreEtoile == 0)
        {
            etoile0.SetActive(true);
            etoile1.SetActive(false);
            etoile2.SetActive(false);
            etoile3.SetActive(false);
        }

        if (nombreEtoile == 1)
        {
            etoile0.SetActive(false);
            etoile1.SetActive(true);
            etoile2.SetActive(false);
            etoile3.SetActive(false);
        }

        if (nombreEtoile == 2)
        {
            etoile0.SetActive(false);
            etoile1.SetActive(false);
            etoile2.SetActive(true);
            etoile3.SetActive(false);
        }

        if (nombreEtoile == 3)
        {
            etoile0.SetActive(false);
            etoile1.SetActive(false);
            etoile2.SetActive(false);
            etoile3.SetActive(true);
        }
    }
}
