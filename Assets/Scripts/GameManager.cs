using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField]private int towerCount = 0;
    [SerializeField]private GameObject gameOverScreen; 
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else 
        {
            Destroy(gameObject);
        }
    }

    
    public void AddTower()
    {
        towerCount++; 
        Debug.Log("Torens in het spel: " +  towerCount);    
    }

    public void RemoveTower()
    {
        towerCount--;
        Debug.Log("Torens in het spel: " + towerCount);

        if (towerCount <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        Debug.Log("Game Over!");
        gameOverScreen.SetActive(true);
    }
}
