using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Enemy enemyPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            CreerEnemy();
        }
    }

    void CreerEnemy()
    {
        var newEnemy = Instantiate(enemyPrefab);
        newEnemy.transform.position = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0);
    }
}