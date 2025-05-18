using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float tempsEnVie = 3f;

    // Update is called once per frame
    void Update()
    {
        tempsEnVie -= Time.deltaTime;
        if (tempsEnVie <= 0)
        {
            Destroy(gameObject);
        }
    }
}