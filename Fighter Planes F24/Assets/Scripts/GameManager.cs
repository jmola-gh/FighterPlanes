using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject player;
    public GameObject enemy;
    public GameObject enemyElite;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(player, transform.position, Quaternion.identity);
        InvokeRepeating("CreateEnemy", 1f, 3f);
        InvokeRepeating("CreateEnemyElite", 3f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateEnemy()
    {
        Instantiate(enemy, new Vector3(Random.Range(-9f, 9f), 8f, 0), Quaternion.identity);
    }

    void CreateEnemyElite()
    {
        Instantiate(enemyElite, new Vector3(-12, Random.Range(2f, 7f), 0), Quaternion.identity);
    }
}
