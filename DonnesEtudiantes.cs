using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonnesEtudiantes : MonoBehaviour
{
    string[] noms = { "Alice", "Bob", "Charlie", "Diana" };
    int[] notes = { 85, 90, 78, 92 };

    // Start is called before the first frame update
    void Start()
    {
        AfficherMoyenne();
        AfficherEtudiant(90);
    }

    void AfficherMoyenne()
    {
        float total = 0;
        for (int i = 0;  i < notes.Length; i++)
        {
            total += notes[i];
        }
        float moyenne = total / notes.Length;
        Debug.Log("La moyenne est de " + moyenne);
    }

    void AfficherEtudiant(int noteMin)
    {
        for (int i = 0;i < notes.Length;i++)
        {
            if (notes[i] >= noteMin)
            {
                Debug.Log(noms[i] + " a obtenu une note superieure a " + noteMin);
            }
        }
    }
}
