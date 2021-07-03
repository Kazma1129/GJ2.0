using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploDeArray : MonoBehaviour
{

    public string color;
    //public string[] textoarray;
    //public string[] textoarray = {"a",5,"b"};
    public GameObject[] balls;
    public string[] arr;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")){
            color = Instantiate(balls[Random.Range(0, balls.Length)]).name;

            //color.name = Random.Range(0, balls.Length).ToString();
            //gameObject.name;
          //  color = Random.Range(0, balls.Length);

            
            if (color == "yellow(Clone)" || color == "Blue(Clone)" ||  color == "green(Clone)")
            {
                //Debug.Log(gameObject.name, gameObject);
                Debug.Log(color);
                arr[0] = color;
                
            }
            

        }



    }
}
