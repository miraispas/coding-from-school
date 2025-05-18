using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI score;
    public TextMeshProUGUI vies;

    public Image victory;
    public Image defeat;
    public Image title;

    public Button start;
    public Button mainMenu;
    public Button restart;

    public Player player;
    public EnemySpawner enemySpawner;
    public Enemy enemy;
    public StrongEnemy boss;


    private int Score = 0;

    public int playerLives = 3;

    

    void Start()
    {
        enemySpawner = FindAnyObjectByType<EnemySpawner>();

        player.gameObject.SetActive(false);
        enemySpawner.gameObject.SetActive(false);
        defeat.gameObject.SetActive(false);
        victory.gameObject.SetActive(false);

        Score = 0;
    }


    void Update()
    {
        start.onClick.AddListener(StartScene);
        mainMenu.onClick.AddListener(RestartScene);
        restart.onClick.AddListener(StartScene);

        vies.text = playerLives.ToString();
        score.text = Score.ToString();

        if (Input.GetKeyDown(KeyCode.R))
        {
            StartScene();
        }
    }

    public void LoseLife()
    {
        playerLives -= 1;

        if (playerLives <= 0)
        {
            playerLives = 0;
            DefeatScreen();
        }
    }

    public void GainLife()
    {
        playerLives += 1;
    }
    public void IncreaseScore()
    {
        Score += 1;
    }

    public void StartScene()
    {
        Score = 0;
        playerLives = 3;

        player.gameObject.SetActive(true);
        player.transform.localPosition = new Vector2(0, -4);

        enemySpawner.gameObject.SetActive(true);
        enemy.gameObject.SetActive(true);
        boss.gameObject.SetActive(true);

        start.gameObject.SetActive(false);
        victory.gameObject.SetActive(false);
        defeat.gameObject.SetActive(false);
        title.gameObject.SetActive(false);
        restart.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(false);

        enemySpawner.spawnDelay = 4f;
        enemySpawner.bossDelay = 0f;
    }


    public void MainScreen()
    {
        player.gameObject.SetActive(false);

        enemySpawner.gameObject.SetActive(false);
        enemy.gameObject.SetActive(false);
        boss.gameObject.SetActive(false);

        start.gameObject.SetActive(true);
        title.gameObject.SetActive(true);
    }

    public void VictoryScreen()
    {
        victory.gameObject.SetActive(true);
        mainMenu.gameObject.SetActive(true);
        restart.gameObject.SetActive(true);

        enemySpawner.gameObject.SetActive(false);
        enemy.gameObject.SetActive(false);
        boss.gameObject.SetActive(false);
        player.gameObject.SetActive(false);

    }

    public void DefeatScreen()
    {
        defeat.gameObject.SetActive(true);
        mainMenu.gameObject .SetActive(true);
        restart.gameObject.SetActive(true);

        enemySpawner.gameObject.SetActive(false);
        enemy.gameObject.SetActive(false);
        boss.gameObject.SetActive(false);
        player.gameObject.SetActive(false);

    }

    public void RestartScene()
    {
        player.gameObject.SetActive(false);

        enemySpawner.gameObject.SetActive(false);
        enemy.gameObject.SetActive(false);
        boss.gameObject.SetActive(false);

        mainMenu.gameObject.SetActive(false);
        restart.gameObject.SetActive(false);
        victory.gameObject .SetActive(false);
        defeat.gameObject .SetActive(false);

        start.gameObject.SetActive(true);
        title.gameObject.SetActive(true);
    }
}
