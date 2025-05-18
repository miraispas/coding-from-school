using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VieJoueur : MonoBehaviour
{
    int vie = 100;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int degat = Random.Range(10, 21);
            int soin = Random.Range(5, 15);

            vie = vie - degat + soin;

            if (vie > 100)
            {
                vie = 100;
            }

            Debug.Log("Damage: " + degat + " - Soin: " + soin + " - Vie Restante: " + vie);
            
            if (vie <= 0)
            {
                Debug.Log("GAME OVER");
            }
        }
    }
}
