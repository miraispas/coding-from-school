using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDeplacementRotation : MonoBehaviour
{
    public int vitesseDeplacement = 5;
    public float vitesseRotation = 100;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            DeplacerJoueur(vitesseDeplacement);
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            DeplacerJoueur(-vitesseDeplacement);
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            TournerJoueur(-vitesseRotation);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            TournerJoueur(vitesseRotation);
        }
    }

    void DeplacerJoueur(float vitesseDeplacement)
    {
        transform.Translate(new Vector3(0, vitesseDeplacement * Time.deltaTime, 0));
    }

    void TournerJoueur(float vitesseRotation)
    {
        transform.Rotate(new Vector3(0, 0, vitesseRotation * Time.deltaTime));
    }
}
