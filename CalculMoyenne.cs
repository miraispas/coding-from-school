using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculMoyenne : MonoBehaviour
{
    public List<float> floatsChoisi = new List<float>();

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("La moyenne est de " + TrouveMoyenne(floatsChoisi));
    }

    float TrouveMoyenne(List<float> floats)
    {
        float somme = 0.0f;
        foreach (float f in floats)
        {
            somme += f;
        }
        return somme / floats.Count;
    }
}