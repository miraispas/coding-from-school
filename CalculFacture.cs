using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculFacture : MonoBehaviour
{
    float[] prix = { 3.99f, 2.99f, 5.99f, 9.99f, 4.99f };
    int[] quantites = { 4, 6, 2, 7, 2 };

    // Start is called before the first frame update
    void Start()
    {
        float total = CalculerTotal();
        Debug.Log("Le montant avant taxes est de " + total);
        total *= 1.05f; // TPS
        total *= 1.09975f; // TVQ
        Debug.Log("Le montant total de la facture est de " +  total);

        if (total > 100)
        {
            total *= 0.9f; // Reduction de 10%
            Debug.Log("Un rabais donne un montant total de " + total);
        }
    }

    float CalculerTotal()
    {
        float total = 0;
        for (int i = 0; i < prix.Length; i++)
        {
            total += prix[i] * quantites[i];
        }
        return total;
    }
}
