using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    public float dobbleJumpForce;

    // rien = 2  ,  droite = 1   ,   gauche = 0
    public int lasteToutsch;

    public bool isJumpingR = false;
    public bool isJumpingL = false;

    private bool dobbleJumpForceRight = false;
    private bool dobbleJumpForceLeft = false;

    public Rigidbody2D rb;

    private void Start()
    {
        lasteToutsch = 2;
    }

    private void Update()
    {
        if(lasteToutsch == 0)
        {
            dobbleJumpForceRight = true;
        }
        if (lasteToutsch == 1)
        {
            dobbleJumpForceRight = false;
        }

        if (lasteToutsch == 1)
        {
            dobbleJumpForceLeft = true;
        }
        if (lasteToutsch == 0)
        {
            dobbleJumpForceLeft = false;
        }

        // ---------------------------------------------------------------------------------------------------------------------------------------

        if (Input.GetKeyDown("right") || isJumpingR == true)
        {
            if(dobbleJumpForceRight == true)
            {
                rb.AddForce(new Vector2(dobbleJumpForce, jumpForce));
                isJumpingR = false;
                lasteToutsch = 1;
            }
            else
            {
                rb.AddForce(new Vector2(moveSpeed, jumpForce));
                isJumpingR = false;
                lasteToutsch = 1;
            }
        }

        if (Input.GetKeyDown("left") || isJumpingL == true)
        {
            if(dobbleJumpForceLeft == true)
            {
                rb.AddForce(new Vector2(-dobbleJumpForce, jumpForce));
                isJumpingL = false;
                lasteToutsch = 0;
            }
            else
            {
                rb.AddForce(new Vector2(-moveSpeed, jumpForce));
                isJumpingL = false;
                lasteToutsch = 0;
            }
        }
    }

    public void InputButtonRight()
    {
        isJumpingR = true;
    }

    public void InputButtonLeft()
    {
        isJumpingL = true;
    }
}
