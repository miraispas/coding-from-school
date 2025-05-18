using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetDes : MonoBehaviour
{
    int[] resultatDes = new int[10];

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Voici le resultat de tout les jets de des");
        for (int i = 0; i < resultatDes.Length; i++)
        {
            resultatDes[i] = Random.Range(1, 7);
        }

        AfficherResults(resultatDes);
        List<int> resultats = AnalyserResultats(resultatDes);

        Debug.Log("Voici le total de chaque resultat");
        for (int i = 0; i < resultats.Count; i++)
        {
            Debug.Log(i + 1 + " a ete lancé " + resultats[i] + " fois!");
        }

        switch (resultats[5])
        {
            case 0:
                Debug.Log("Pas de chance");
                break;
            case 1:
            case 2:
            case 3:
                Debug.Log("Un peu de chance");
                break;
            case 4:
            case 5:
            case 6:
                Debug.Log("Pas mal de chance");
                break;
            case 7:
            case 8:
            case 9:
                Debug.Log("Beaucoup de chance");
                break;
            case 10:
                Debug.Log("Ca arrivera pas XD");
                break;
        }
    }

    void AfficherResults(int[] resultats)
    {
        foreach (int resultat in resultats)
        {
            Debug.Log(resultat);
        }
    }

    List<int> AnalyserResultats(int[] resultats)
    {
        List<int> listResultats = new List<int>(new int[6]);
        for (int i = 0; i < resultats.Length; i++)
        {
            listResultats[resultats[i] - 1]++;
        }
        return listResultats;
    }
}
