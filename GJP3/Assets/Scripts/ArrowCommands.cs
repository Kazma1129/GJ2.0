using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowCommands : MonoBehaviour
{
    public bool isArrowIn = false;
    private SpriteRenderer sr;
    public float backToWhiteArrowTimer = 0f;
    public int red;
    public int green;
    public int blue;
    public string input;


    // Start is called before the first frame update
    void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        

            if (Input.GetKeyDown(input))
            {
            sr.color = new Color(red,green,blue);
            StartCoroutine(backToWhite());

            }

    }


    IEnumerator backToWhite()
    {
        yield return new WaitForSeconds(backToWhiteArrowTimer);
        sr.color = new Color(255, 255, 255);

    }
  
    
}
