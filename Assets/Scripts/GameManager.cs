using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI ScoreText, BestScoreText, PlayTimeText;
    public GameObject GameOverPanel;
    public GameObject[] spawner;

    private float NextSpawnerTime;
    // Start is called before the first frame update
    void Start()
    {
        NextSpawnerTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnerManagement();
    }


    public void GameOver()
    {
        Time.timeScale = 0;
        GameOverPanel.SetActive(true);
        ScoreText.text = ScoreScript.score.ToString();
        BestScoreText.text = PlayerPrefs.GetInt("Best").ToString();
        PlayTimeText.text = Time.time.ToString();
    }


    public void Pause()
    {
        Time.timeScale = 0;
    }
    public void Resume()
    {
        Time.timeScale = 1;
    }


    void SpawnerManagement()
    {
        if(Time.time > NextSpawnerTime)
        {
            int spr = Random.Range(0, 6);
            if (spr==0)
            {
                spawner[0].SetActive(true);
            }
            if (spr == 1)
            {
                spawner[1].SetActive(true);
            }
            if (spr == 2)
            {
                spawner[2].SetActive(true);
            }
            if (spr == 3)
            {
                spawner[3].SetActive(true);
            }
            if (spr == 4)
            {
                spawner[4].SetActive(true);
            }
            if (spr == 5)
            {
                spawner[5].SetActive(true);
            }
            NextSpawnerTime = Time.time + 2;
            Invoke("DeactivateAllSpawners", 2);
        }
    }
    void DeactivateAllSpawners()
    {
        spawner[0].SetActive(false);
        spawner[1].SetActive(false);
        spawner[2].SetActive(false);
        spawner[3].SetActive(false);
        spawner[4].SetActive(false);
        spawner[5].SetActive(false);
    }
}
