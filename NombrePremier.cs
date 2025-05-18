using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NombrePremier : MonoBehaviour
{
    public int finBoucle = 100;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= finBoucle; i++)
        {
            bool estPremier = true;

            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    estPremier = false;
                }
            }

            if (estPremier)
            {
                Debug.Log(i + " est un nombre premier");
            }
        }
    }
}
