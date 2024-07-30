using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
    public int maxCount;
    public int enemyCount;
    public float spawnTime = 3f;
    public float curTime;
    public Transform[] spawnPoints;
    public GameObject enemy;

    public static SpawnManager _instance;

    private void Start() {
        _instance = this;
    }
    private void Update() {
        if(curTime >= spawnTime && enemyCount < maxCount) {
            int x = Random.Range(0, spawnPoints.Length);
            SpawnEnemy(x);
        }
        curTime += Time.deltaTime;
    }

    public void SpawnEnemy(int ranNum) {
        curTime = 0;
        enemyCount++;
        Instantiate(enemy, spawnPoints[ranNum]);
    }
}
