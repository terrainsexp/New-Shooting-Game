using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendEnemySpawnsManager : MonoBehaviour
{
   

    [SerializeField]
    private GameObject Enemy;
    public Transform[] SpawnPoints;

    [SerializeField]
    public int tzEnemyCount;

    private int Initial_tz_Enemy_Countl;

    public float wait_before_spawn_enemy = 10f;
    public static FriendEnemySpawnsManager instance;

    public int CountEnemiesGenerate=0;

    [HideInInspector]
    public bool Enemydestroyed = false;
    int index;
    // Start is called before the first frame update
    void Start()
    {

        instance = this;

        Initial_tz_Enemy_Countl = tzEnemyCount;

        SpawnZombies(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnZombies()
    {
        SpawnTzZOmbie();
        StartCoroutine(ChecktoSpawnZombies());
    }

    public void SpawnTzZOmbie()
    {
        index = Random.Range(0, SpawnPoints.Length);

        for(int i =0; i<tzEnemyCount; i++)
        {
            Instantiate(Enemy, SpawnPoints[index].position, Quaternion.identity);

            CountEnemiesGenerate++;
            index = Random.Range(0, SpawnPoints.Length);
        }

        tzEnemyCount = 0;

    }


    public void ZombieDied(bool ZombieDie)
    {
        if (ZombieDie)
        {
            tzEnemyCount++;

            if(tzEnemyCount > Initial_tz_Enemy_Countl)
            {
                tzEnemyCount = Initial_tz_Enemy_Countl;
            }
        }
    }

    IEnumerator ChecktoSpawnZombies()
    {
        yield return new WaitForSeconds(wait_before_spawn_enemy);
        SpawnTzZOmbie();

        StartCoroutine(ChecktoSpawnZombies());


    }
}
