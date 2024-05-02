using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelManager : MonoBehaviour
{

    public GameObject[] Levels;

    public GameObject Player;
    public bool respawnPlayer = false;
    public GameObject[] playerSpawns;
    int curLevel;

    [Header("Only for Testing Levels")]
    public bool testLevel = false;
    public int testLevelNum = 1;
    [HideInInspector]
    public int BlueNumPoints = 0;
    [HideInInspector]
    public int RedNumPoints = 0;
    public GameObject MiamiEnvi;
    public GameObject ContainersEnvi;
    public GameObject EnmeyLeftUi;
    public GameObject TDM_UI;
    public Text ShowBluePoints;
    public Text ShowRedPoints;
    public static LevelManager instance;
    void Start()
    {
        instance = this;
        //Preferences.Instance.Reset ();
        if (testLevel)
        {
            curLevel = testLevelNum;
            Preferences.Instance.Level = testLevelNum;
        }
        else
            curLevel = Preferences.Instance.Level;

        if (curLevel >= 1 && curLevel <= 12)
        {
            ContainersEnvi.SetActive(false);
            MiamiEnvi.SetActive(true);
        }
        else if (curLevel >=13 && curLevel <= 24 || curLevel ==37)
        {
            ContainersEnvi.SetActive(true);
            MiamiEnvi.SetActive(false);
        }

        if (curLevel == 37)
        {
            EnmeyLeftUi.SetActive(false);
            TDM_UI.SetActive(true);
        }
        PlayerSpawning();

        Levels[curLevel - 1].SetActive(true);

        Debug.Log("level " + Preferences.Instance.Level);
    }

    private void Update()
    {
        if (BlueNumPoints == 30)
        {
            GameManager.instance.LevelComplete();
            return;
        }
        else if(RedNumPoints==30)
        {
            GameManager.instance.GameOver();
            return;
        }
        ShowBluePoints.text = BlueNumPoints.ToString();
        ShowRedPoints.text = RedNumPoints.ToString();
    }

    public void PlayerSpawning()
    {
        if (Player && respawnPlayer)
        {
            Player.transform.position = playerSpawns[curLevel - 1].transform.position;
            Player.transform.rotation = playerSpawns[curLevel - 1].transform.rotation;
        }
    }
}
