using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    /// <summary>
    /// Destruye al enemigo al no ser visible con la camara.
    /// </summary>
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);  
    }

}
