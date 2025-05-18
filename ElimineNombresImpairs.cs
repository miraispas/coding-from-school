using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ElimineNombresImpairs : MonoBehaviour
{
    public List<int> nombresChoisi = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        foreach (int nombre in nombresChoisi)
        {
            Debug.Log(nombre);
        }

        retirerImpairs(nombresChoisi);

        foreach (int nombre in nombresChoisi)
        {
            Debug.Log(nombre);
        }
    }

    void retirerImpairs(List<int> nombres)
    {
        for (int i = nombres.Count - 1; i >= 0; i--)
        {
            if (nombres[i] % 2 == 1)
            {
                nombres.RemoveAt(i);
            }
        }
    }
}