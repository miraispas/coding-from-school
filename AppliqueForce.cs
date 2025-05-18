using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppliqueForce : MonoBehaviour
{
    public float force = 0.1f;

    private Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            body.AddForce(new Vector2(0, force), ForceMode2D.Force);
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            body.AddForce(new Vector2(0, force), ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.C))
        {
            body.AddForce(new Vector2(0, force), ForceMode2D.Force);
        }
    }
}
