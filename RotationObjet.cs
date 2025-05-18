using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationObjet : MonoBehaviour
{
    public int vitesse;

    // Update is called once per frame
    void Update()
    {
        TournerObject(vitesse);
    }

    void TournerObject(float vitesse)
    {
        transform.Rotate(new Vector3(0, 0, vitesse) * Time.deltaTime);
        // Time.deltaTime représente le temps depuis la dernière Update
    }
}