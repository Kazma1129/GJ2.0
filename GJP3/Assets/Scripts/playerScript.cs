using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerScript : MonoBehaviour
{
    public bool isHited = false;
    public float speed;
    private Rigidbody2D myRigidbody;
    private Vector3 change;
    public int daño;
    public ParticleSystem particleHit;
    public ParticleSystem particleDeath;


    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
        change.y = Input.GetAxisRaw("Vertical") * Time.deltaTime * speed;
        if (change != Vector3.zero)
        {
            transform.Translate(new Vector3(change.x, change.y));
        }

        if (GameManager.Instance.health <= 0)
        {
            particleDeath.Play();

            GameManager.Instance.isAlive = false;
            Destroy(this.gameObject,.5f);
        }
    }

    //destruye enemigo si sale del margen de la camara
   /* void OnBecameInvisible()
    {
        GameManager.Instance.isAlive = false;
        Destroy(this.gameObject);
    }
   */


    IEnumerator immunity()
    {
        // tiempo de inmunidad si el jugador es golpeado.
        yield return new WaitForSeconds(0.5f);
        isHited = false;
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Enemy")
        {
            isHited = true;
           
                particleHit.Play();

                GameManager.Instance.health--;
                StartCoroutine(immunity());
            

        }

    }
}

