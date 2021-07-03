using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCircles : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 screenbounds;
    
    public bool leftA;
    public bool rightA;
    public bool upA;
    public bool downA;
    public bool isArrowIn = false;
    public string input;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "left":
                leftA = true;
                isArrowIn = true;
                break;
            case "right":
                rightA = true;
                isArrowIn = true;
                break;
            case "up":
                upA = true;
                isArrowIn = true;
                break;
            case "down":
                downA = true;
                isArrowIn = true;
                break;
            default:
                break;

        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "left":
                leftA = false;
                isArrowIn = false;
                break;
            case "right":
                rightA = false;
                isArrowIn = false;
                break;
            case "up":
                upA = false;
                isArrowIn = false;
                break;
            case "down":
                downA = false;
                isArrowIn = false;
                break;
            default:
                break;

        }
    }


    void Update()
    {
        if (Input.GetKeyDown(input)&& isArrowIn)
        {
            Destroy(this.gameObject);
        }
    }

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
