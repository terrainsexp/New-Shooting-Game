using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Statistics : MonoBehaviour
{
    public int myscore;
    public Text scores;
    public Text scores1;
    public Text scores2;
    public Text scores3;

    public int KillEnemyCount = 0;
    public Text KilledEnemies;
    public Text KilledEnemies1;
    public Text KilledEnemies2;
    public Text KilledEnemies3;


    public static Statistics instance;

    public Text Scores1
    {
        get
        {
            return scores1;
        }

        set
        {
            scores1 = value;
        }
    }

    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void killingEnemies()
    {
        CoinScore();
        KillEnemyCount += 1;
        KilledEnemies.text = KillEnemyCount.ToString();
        KilledEnemies1.text = KillEnemyCount.ToString();
        KilledEnemies2.text = KillEnemyCount.ToString();
       // KilledEnemies3.text = KillEnemyCount.ToString();
    }


    public void CoinScore()
    {
        myscore = PlayerPrefs.GetInt("score");
        scores.text = myscore.ToString();
        scores1.text = myscore.ToString();
        scores2.text = myscore.ToString();
       // scores3.text = myscore.ToString();
    }
}
