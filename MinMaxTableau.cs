using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinMaxTableau : MonoBehaviour
{
    public int[] entiersChoisi = new int[5];

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Le maximum est " + trouveMax(entiersChoisi));
        Debug.Log("Le minimum est " + trouveMin(entiersChoisi));
    }

    int trouveMax(int[] entiers)
    {
        int max = int.MinValue;
        for (int i = 0; i < entiers.Length; i++)
        {
            if (entiers[i] > max)
            {
                max = entiers[i];
            }
        }
        return max;
    }

    int trouveMin(int[] entiers)
    {
        int min = int.MaxValue;
        for (int i = 0; i < entiers.Length; i++)
        {
            if (entiers[i] < min)
            {
                min = entiers[i];
            }
        }
        return min;
    }
}