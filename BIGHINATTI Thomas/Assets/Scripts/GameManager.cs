using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private int life = 3;
    [SerializeField] GameObject prefab;
    [SerializeField] private Transform spawnPoint;
    
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        SpawnBall();
    }

    public void LoseBall()
    {
        Debug.Log("Lose Ball");

        life--;
        SpawnBall();
    }

    public void GameOver()
    {
        if (life < 1)
        {
            Debug.Log("Game Over");
        }
    }

    void SpawnBall()
    {
        Instantiate(prefab, spawnPoint.position, Quaternion.identity, transform);
    }
}
