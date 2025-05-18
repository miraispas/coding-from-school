using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Enemy[] enemy;
    public StrongEnemy boss;

    public float spawnDelay = 4f;
    public float bossDelay = 0f;


    void Start()
    { 
    
    } 


    void Update()
    {

        spawnDelay += Time.deltaTime;
        bossDelay += Time.deltaTime;

        if (bossDelay < 40f)
        {
            if (spawnDelay >= 5f)
            {
                SpawnEnemies();
                spawnDelay = 0f;
            }
        }
        
        if (bossDelay > 40f && bossDelay <55f)
        {
            if (spawnDelay >= 2.5f)
            {
                SpawnEnemies();
                spawnDelay = 0f;
            }
        }
        
        if (bossDelay >= 60f)
        {
            SpawnBoss();
            bossDelay = 0f;
            spawnDelay = -25f;
        }
    }

    void SpawnEnemies()
    {
        int EnemyNumber = Random.Range(6, 8);
        int PositionX = Random.Range(-1, 1);
        var Decalage = PositionX;

        for (int i = 0; i < EnemyNumber; i++)
        {
            var newEnemy = Instantiate(enemy[Random.Range(0,4)]);
            newEnemy.transform.position = new Vector2(PositionX, 3);  

            if (Decalage > 0)
            {
                PositionX -= 1;
            }
            else
            {
                PositionX += 1;
            }
        }
    }

    void SpawnBoss()
    {
        var newStrongEnemy = Instantiate(boss);
        newStrongEnemy.transform.position = new Vector2(0, 3);
    }
}
