using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateurGeometrique : MonoBehaviour
{
    public int nombreLigne = 5;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = nombreLigne; i > 0; i--)
        {
            string message = "";
            for (int j = 0; j < i; j++)
            {
                message += "*";
            }
            Debug.Log(message);
        }
    }
}