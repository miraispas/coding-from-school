using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceFibonacci : MonoBehaviour
{
    public int longeurSuite = 10;
    int premierNombre = 0;
    int deuxiemeNombre = 1;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < longeurSuite; i++)
        {
            int nombreTemporaire = premierNombre + deuxiemeNombre;
            Debug.Log(nombreTemporaire);

            premierNombre = deuxiemeNombre;
            deuxiemeNombre = nombreTemporaire;
        }
    }
}