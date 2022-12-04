using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant_Script : MonoBehaviour
{
    private GameObject AliveAnt;

    private Transform DeadAnt;

    private Transform parent;

    public bool isBee;

    public bool isLife;

    private GameManager gameManager;
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>().GetComponent<GameManager>();
        if(!isLife)
        {
            AliveAnt = this.gameObject;
            DeadAnt = transform.GetChild(0);
            parent = transform.parent;
        }
        
    }

    private void OnMouseUpAsButton()
    {
        if(isBee)
        {
            gameManager.GameOver();
        }
        if(isLife)
        {
            Destroy(gameObject);
            LifeSystem.lifeCount += 1;
        }
        if (!isLife)
        {
            AliveAnt.GetComponent<SpriteRenderer>().enabled = false;
            AliveAnt.GetComponent<BoxCollider2D>().enabled = false;
            DeadAnt.gameObject.SetActive(true);
            parent.GetComponent<Animator>().enabled = false;
            if (!isBee)
            {
                ScoreScript.score += 1;
            }
            Destroy(parent.gameObject, 5);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(!isBee)
        {
            LifeSystem.lifeCount -= 1;
            if(LifeSystem.lifeCount==0)
            {
                gameManager.GameOver();
            }
        }
        Destroy(parent.gameObject);
    }

    void Update()
    {
        if(isLife)
        {
            Vector2 pos = transform.position;
            pos.y -= 0.4f * Time.deltaTime;
            transform.position = pos;
        }
    }
}
