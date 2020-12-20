using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager1 : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    public GameObject TitleScreen;

    public GameObject[] EnemeyPrefabs;

    public float spawnTimer = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", 2, spawnTimer);



    }

    // Update is called once per frame
    void Update()
    {
        if(score>5)
        {
            spawnTimer = 0.5f;
        }
    }
    void SpawnRandomEnemy()
    {

        
        //randomly spawn location
        Vector3 spawnPos = new Vector3(70, Random.Range(-20, 20), 0);
        int enemeyIndex = Random.Range(0, EnemeyPrefabs.Length);

        Instantiate(EnemeyPrefabs[enemeyIndex], spawnPos,
            EnemeyPrefabs[enemeyIndex].transform.rotation);

    }
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "score:" + score;


    }
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }
    public void RestartGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void StartGame()
    {
        TitleScreen.gameObject.SetActive(false);
        scoreText.gameObject.SetActive(true);
        score = 0;
        UpdateScore(0);
        
        SpawnRandomEnemy();
        
    }
    

}