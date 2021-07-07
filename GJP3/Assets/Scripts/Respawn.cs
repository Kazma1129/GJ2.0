using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform playerPrefab;
    public Transform respawn;

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.isAlive == false)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }

    }

        public void restartGame() {

        GameManager.Instance.isAlive = true;
        transform.GetChild(0).gameObject.SetActive(false);
        GameManager.Instance.health = 5;
        Instantiate(playerPrefab);
    
    }
}
