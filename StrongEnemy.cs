using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrongEnemy : Character
{
    public ProjectileBoss projectileBoss;

    private float descenteBoss = 0f;
    private float projectileDelay = 0f;
    private int bossLife;

    private GameManager gameManager;
    private Animator animator;
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        animator = GetComponent<Animator>();

        bossLife = 20;
    }


    void Update()
    {
        descenteBoss += Time.deltaTime;
        projectileDelay += Time.deltaTime;

        if (descenteBoss >= 5f)
        {
            transform.localPosition += new Vector3(0, -1.5f, 0);

            descenteBoss = 0f;
        }

        if (projectileDelay >= 3f)
        {
            var newProjectileBoss = Instantiate(projectileBoss);
            Vector3 spawnPosition = transform.position + new Vector3(0, -1, 0);
            newProjectileBoss.transform.position = spawnPosition;
            projectileDelay = 0f;
        }

        if (gameManager.playerLives <= 0)
        {
            Destroy(gameObject);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Destroy(gameObject);
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Kill Zone"))
        {
            Destroy(gameObject);
            gameManager.DefeatScreen();
        }

        if (collision.gameObject.CompareTag("Projectile"))
        {
            Debug.Log("Projectile touché par le boss. Vie du boss avant : " + bossLife);
            bossLife -= 1;
            gameManager.IncreaseScore();
            Destroy(collision.gameObject);
            Debug.Log("Vie du boss après : " + bossLife);

            if (bossLife <= 0)
            {
                animator.SetBool("Explosion", true);

                Destroy(gameObject, 0.3f);

                gameManager.VictoryScreen();
            }
        }
    }
    
}
