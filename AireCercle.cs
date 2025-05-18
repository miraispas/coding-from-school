using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AireCercle : MonoBehaviour
{
    public float rayon = 10;

    // Start is called before the first frame update
    void Start()
    {
        float aire = CalculerAire(rayon);
        Debug.Log("L'aire, du cercle de rayon " + rayon + " est " + aire);
    }

    float CalculerAire(float rayon)
    {
        return Mathf.PI * Mathf.Pow(rayon, 2);
    }
}