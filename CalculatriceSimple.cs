using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculatriceSimple : MonoBehaviour
{
    public char calcul = '/';
    public int nombre1;
    public int nombre2;

    // Start is called before the first frame update
    void Start()
    {
        switch (calcul)
        {
            case '+':
                Debug.Log(Addition(nombre1, nombre2));
                break;
            case '-':
                Debug.Log(Soustraction(nombre1, nombre2));
                break;
            case '*':
                Debug.Log(Multiplication(nombre1, nombre2));
                break;
            case '/':
                Debug.Log(Division(nombre1, nombre2));
                break;
            case '%':
                Debug.Log(Reste(nombre1, nombre2));
                break;
            default:
                Debug.Log("Ce symbol n'existe pas");
                break;
        }
    }

    int Addition(int nombreAddition1, int nombreAddition2)
    {
        return nombreAddition1 + nombreAddition2;
    }

    int Soustraction(int nombreSoustraction1, int nombreSoustraction2)
    {
        return nombreSoustraction1 - nombreSoustraction2;
    }

    int Multiplication(int nombreMultiplication1, int nombreMultiplication2)
    {
        return nombreMultiplication1 * nombreMultiplication2;
    }

    int Division(int nombreDivision1, int nombreDivision2)
    {
        return nombreDivision1 / nombreDivision2;
    }

    int Reste(int nombreReste1, int nombreReste2)
    {
        return nombreReste1 % nombreReste2;
    }

}
