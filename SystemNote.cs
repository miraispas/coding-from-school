using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemNote : MonoBehaviour
{
    int score;

    int score1;
    int score2;
    int score3;
    int score4;
    int score5;

    // Start is called before the first frame update
    void Start()
    {
        score1 = Random.Range(0, 101);
        score2 = Random.Range(0, 101);
        score3 = Random.Range(0, 101);
        score4 = Random.Range(0, 101);
        score5 = Random.Range(0, 101);

        score = (score1 + score2 + score3 + score4 + score5) / 5;
        Debug.Log(score);

        if (score < 60)
        {
            Debug.Log("F");
        }
        else if (score >= 60 && score < 70)
        {
            Debug.Log("D");
        }
        else if (score >= 70 && score < 80)
        {
            Debug.Log("C");
        }
        else if (score >= 80 && score < 90)
        {
            Debug.Log("B");
        }
        else if (score >= 90 && score <= 100)
        {
            Debug.Log("A");
        }
    }
}
