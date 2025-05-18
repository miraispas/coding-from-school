using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalleController : MonoBehaviour
{
    public float forceDeplacement;
    public float forceSaut;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector2(-forceDeplacement, 0), ForceMode2D.Force);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector2(forceDeplacement, 0), ForceMode2D.Force);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, forceSaut), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.AddForce(new Vector2(0, forceSaut), ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Je suis entrer en collision avec " + collision.gameObject.name);
        Debug.Log("Fait quelque chose sur la player");
        Destroy(collision.gameObject);
    }
}
