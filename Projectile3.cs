using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Projectile : MonoBehaviour
{
    public float vitesse = 5f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0, vitesse * Time.deltaTime));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Debug.Log("J'ai frapper un mur");
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("J'ai frapper un enemy");
            Destroy(collision.gameObject);
        }

        Destroy(gameObject);
    }
}
