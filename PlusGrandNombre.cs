using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusGrandNombre : MonoBehaviour
{
    public int nombre1 = 43;
    public int nombre2 = 23;

    // Start is called before the first frame update
    void Start()
    {
        int nombreMax = Max(nombre1, nombre2);
        Debug.Log("Le plus grand nombre est " + nombreMax);
    }

    int Max(int a, int b)
    {
        if (a > b)
        {
            return a;
        }

        return b;
    }
}