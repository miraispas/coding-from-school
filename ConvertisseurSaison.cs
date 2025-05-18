using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertisseurSaison : MonoBehaviour
{
    public int moisChoisi = 1;

    // Start is called before the first frame update
    void Start()
    {
        switch (moisChoisi)
        {
            case 3:
            case 4:
            case 5:
                Debug.Log("Printemps");
                break;
            case 6:
            case 7:
            case 8:
                Debug.Log("Été");
                break;
            case 9:
            case 10:
            case 11:
                Debug.Log("Automne");
                break;
            case 12:
            case 1:
            case 2:
                Debug.Log("Hiver");
                break;
        }
    }
}