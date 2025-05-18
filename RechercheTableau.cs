using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RechercheTableau : MonoBehaviour
{
    public int entierChoisi = 5;

    // Start is called before the first frame update
    void Start()
    {
        int[] monTableauEntiers = { 4, 5, 23, 52, 6, 3, 6, 2, 7, 3, 5 };

        Debug.Log(EstPresent(entierChoisi, monTableauEntiers));
    }

    bool EstPresent(int entier, int[] tableauEntiers)
    {
        foreach (int entierDuTableau in tableauEntiers)
        { 
            if (entier == entierDuTableau)
            {
                return true;
            }
        }
        return false;
    }
}