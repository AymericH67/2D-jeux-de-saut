using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float health;
    public float myMaxHealth;
    public int coin;
    public string lobby;

    public Text coinText;

    public GameObject deathPanel;

    private void Start()
    {
        health = myMaxHealth;
    }

    void Update()
    {
        coinText.text = "" + coin;

        print ("il nous reste: " + health + "PV");

        if(health <= 0)
        {
            deathPanel.SetActive(true);

            SceneManager.LoadScene(lobby);
        }

    }
}
