using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileAttente : MonoBehaviour
{
    public int nombrePersonne = 100;

    // Start is called before the first frame update
    void Start()
    {
        while (nombrePersonne > 0)
        {
            int ajout = Random.Range(0, 2);
            int retrait = Random.Range(0, 4);
            Debug.Log(ajout + " personnes sont arrivé");
            Debug.Log(retrait + " personnes ont quitté");

            nombrePersonne = nombrePersonne + ajout - retrait;
            Debug.Log("Il y a maintenant " + nombrePersonne + " dans la file d'attente");
        }

        Debug.Log("LA FILE EST FINALEMENT VIDE!");
    }
}

