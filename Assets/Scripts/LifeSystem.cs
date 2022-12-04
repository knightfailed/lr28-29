using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSystem : MonoBehaviour
{
    public GameObject[] lifes;

    public static int lifeCount;
    // Start is called before the first frame update
    void Start()
    {
        lifeCount = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(lifeCount == 5)
        {
            lifes[0].SetActive(true);
            lifes[1].SetActive(true);
            lifes[2].SetActive(true);
            lifes[3].SetActive(true);
            lifes[4].SetActive(true);
        }
        if(lifeCount == 4)
        {
            lifes[0].SetActive(true);
            lifes[1].SetActive(true);
            lifes[2].SetActive(true);
            lifes[3].SetActive(true);
            lifes[4].SetActive(false);
        }
        if(lifeCount == 3)
        {
            lifes[0].SetActive(true);
            lifes[1].SetActive(true);
            lifes[2].SetActive(true);
            lifes[3].SetActive(false);
            lifes[4].SetActive(false);
        }
        if(lifeCount == 2)
        {
            lifes[0].SetActive(true);
            lifes[1].SetActive(true);
            lifes[2].SetActive(false);
            lifes[3].SetActive(false);
            lifes[4].SetActive(false);
        }
        if(lifeCount == 1)
        {
            lifes[0].SetActive(true);
            lifes[1].SetActive(false);
            lifes[2].SetActive(false);
            lifes[3].SetActive(false);
            lifes[4].SetActive(false);
        }
        if (lifeCount == 0)
        {
            lifes[0].SetActive(false);
            lifes[1].SetActive(false);
            lifes[2].SetActive(false);
            lifes[3].SetActive(false);
            lifes[4].SetActive(false);
        }
    }
}
