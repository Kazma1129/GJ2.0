using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Transform[] shape;
    public int[] coordinates;
    public float[] wt;

    public int atkC;
    public int defC;
    public int hpC;
    public int spAtkC;
    public bool aliveC = true;


    public int atkS;
    public int defS;
    public int hpS;
    public bool aliveS = true;


    public virtual void attack()
    {

        shape[0].transform.position = new Vector3(coordinates[0], coordinates[1], coordinates[2]);
        StartCoroutine(WaitAndReturn());
    }




    IEnumerator WaitAndReturn()
    {
        // suspend execution for 5 seconds
        yield return new WaitForSeconds(wt[0]);
        shape[0].transform.position = new Vector3(coordinates[3], coordinates[1], coordinates[2]);
    }

}
