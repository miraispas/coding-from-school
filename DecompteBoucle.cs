using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecompteBoucle : MonoBehaviour
{
    public int pointDepart = 10;
    public int pointFin = 0;

    // Start is called before the first frame update
    void Start()
    {
        while (pointDepart >= pointFin)
        {
            Debug.Log(pointDepart);
            pointDepart--;
        }
    }
}
