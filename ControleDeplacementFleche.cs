using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDeplacementFleche : MonoBehaviour
{
    public int vitesseDeplacement = 5;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            DeplacerJoueur(vitesseDeplacement);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            DeplacerJoueur(-vitesseDeplacement);
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            MonterDescendre(vitesseDeplacement);
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            MonterDescendre(-vitesseDeplacement);
        }
    }

    void DeplacerJoueur(float vitesseDeplacement)
    {
        transform.Translate(new Vector3(vitesseDeplacement * Time.deltaTime, 0, 0));
    }

    void MonterDescendre(float vitesseDeplacement)
    {
        transform.Translate(new Vector3(0, vitesseDeplacement * Time.deltaTime, 0));
    }
}

