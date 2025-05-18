using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movementSpeed = 10f;
    public Projectile projectile;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector2(-movementSpeed, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector2(movementSpeed, 0) * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            var newProjectile = Instantiate(projectile);
            newProjectile.transform.position = transform.position;
        }
    }
}
