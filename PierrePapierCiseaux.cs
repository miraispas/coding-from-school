using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PierrePapierCiseaux : MonoBehaviour
{
    public string choixJoueur;
    string choixOrdi;

    // Start is called before the first frame update
    void Start()
    {
        int choixRandom = Random.Range(0, 3);

        if (choixRandom == 0 )
        {
            choixOrdi = "pierre";
        }
        if (choixRandom == 1)
        {
            choixOrdi = "papier";
        }
        if (choixRandom == 2)
        {
            choixOrdi = "ciseaux";
        }

        Debug.Log("Choix Joueur: " + choixJoueur);
        Debug.Log("Choix Ordinateur: " + choixOrdi);

        if (choixJoueur == "pierre" && choixOrdi == "ciseaux")
        {
            Debug.Log("Le joueur a gagné");
        }
        else if (choixJoueur == "papier" && choixOrdi == "pierre")
        {
            Debug.Log("Le joueur a gagné");
        }
        else if (choixJoueur == "ciseaux" && choixOrdi == "papier")
        {
            Debug.Log("Le joueur a gagné");
        }
        else if (choixJoueur == "ciseaux" && choixOrdi == "pierre")
        {
            Debug.Log("L'ordinateur a gagné");
        }
        else if (choixJoueur == "pierre" && choixOrdi == "papier")
        {
            Debug.Log("L'ordinateur a gagné");
        }
        else if (choixJoueur == "papier" && choixOrdi == "ciseaux")
        {
            Debug.Log("L'ordinateur a gagné");
        }
        else
        {
            Debug.Log("Match nul");
        }
    }
}
