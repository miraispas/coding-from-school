using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float vitesseRotation;
    public float forceMovement;

    public Projectile projectilePrefab;

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
            transform.Rotate(new Vector3(0, 0, vitesseRotation * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 0, -vitesseRotation * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.up * forceMovement * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            var newProjectile = Instantiate(projectilePrefab);
            newProjectile.transform.position = transform.position;
            newProjectile.transform.rotation = transform.rotation;
        }
    }
}
