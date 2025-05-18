using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompteurPoint : MonoBehaviour
{
    public int scoreIncrement = 1;

    int score = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score = score + scoreIncrement;
            Debug.Log(score);

            if (score % 10 == 0)
            {
                Debug.Log("Ceci est un message SPECIAL!");
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            score = score - scoreIncrement;
            Debug.Log(score);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            score = 0;
            Debug.Log(score);
        }
    }
}
