using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float health;
    public bool isHited = true;
    public float speed;
    private Rigidbody2D myRigidbody;
    private Vector3 change;

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

        if (health < 1)
        {
            Destroy(this.gameObject);
        }
    }

    IEnumerator immunity()
    {
        isHited = false;
        yield return new WaitForSeconds(0.5f);
        isHited = true;
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Enemy")
        {
            if (isHited)
            {
                StartCoroutine(immunity());
                health--;
                HealthNumber.getHealth(health);
            }

        }

    }
}

