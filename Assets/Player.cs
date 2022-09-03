using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float health;
    public float myMaxHealth;
    public int coin;

    public Text coinText;

    private void Start()
    {
        health = 3f;
    }

    void Update()
    {
        coinText.text = "" + coin;

        print ("il nous reste: " + health + "PV");
    }
}
