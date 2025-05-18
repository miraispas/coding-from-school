using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float movementSpeed = 20f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0, movementSpeed) * Time.deltaTime);
    }
}
