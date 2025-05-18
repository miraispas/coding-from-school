using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FonctionEstPair : MonoBehaviour
{
    public int nombreSelectioner = 10;

    // Start is called before the first frame update
    void Start()
    {
        bool verification = EstPair(nombreSelectioner);
        Debug.Log(verification);
    }

    bool EstPair(int nombre)
    {
        return nombre % 2 == 0;
    }
}