using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{
    
	public GameObject pnLevelComplete,pnGamePlay,pnGameOver,pnPause,nextButton;
	public LevelManager levelManager;
    
	bool isCompleted=false;
	bool isOver=false;

    public GameObject levelComp;
    public GameObject GameComp;
    public GameObject PistolGun;
    public GameObject M416Gun;
    public GameObject MachineGun;
    public GameObject ShotGun;
    public GameObject SniperGun;
    public GameObject Grenade;
    public Text TotalGrenadeLeft;
    public GameObject AdsNotAvailable;
    public GameObject Music;
    public GameObject settingPanel;
    public GameObject customizationPanel;
    public static GameManager instance;
	// Use this for initialization
	void Start () 
	{
        instance = this;

        Time.timeScale = 1;
		AudioListener.pause = false;
        
		if (!levelManager)
			levelManager = GameObject.FindObjectOfType<LevelManager> ();

//        SabloSdk.Instance.LogScreen("Level : "+Preferences.Instance.Level);
//		SabloSdk.Instance.HideBanner ();
    }

	void Awake(){
//		SabloSdk.Instance.ShowSequence (1);
	}

    private void Update()
    {
        if (PlayerPrefs.GetInt("Pistol") == 1)
        {
            PistolGun.GetComponent<WeaponBehavior>().haveWeapon = true;
        }

        if (PlayerPrefs.GetInt("M146") == 1)
        {
            M416Gun.GetComponent<WeaponBehavior>().haveWeapon = true;
        }

        if (PlayerPrefs.GetInt("MachineGun") == 1)
        {
            MachineGun.GetComponent<WeaponBehavior>().haveWeapon = true;
        }

        if (PlayerPrefs.GetInt("Sniper") == 1)
        {
            SniperGun.GetComponent<WeaponBehavior>().haveWeapon = true;
        }

        if (PlayerPrefs.GetInt("ShotGun") == 1)
        {
            ShotGun.GetComponent<WeaponBehavior>().haveWeapon = true;
        }

        if (PlayerPrefs.GetInt("grenade") <= 0)
        {
            PlayerPrefs.SetInt("grenade", 0);
        }
        Grenade.GetComponent<WeaponBehavior>().ammo = PlayerPrefs.GetInt("grenade");
        TotalGrenadeLeft.text = PlayerPrefs.GetInt("grenade").ToString();
    }

    public void btn_Next()
	{
        if(Preferences.Instance.Level<levelManager.Levels.Length)
    		Preferences.Instance.Level++;

        if (Preferences.Instance.Level >= 1 && Preferences.Instance.Level <= 12)
        {
            PlayerPrefs.SetInt("EliteMissionPanel", 1);
        }
        if (Preferences.Instance.Level >= 13 && Preferences.Instance.Level <= 24)
        {
            PlayerPrefs.SetInt("RoyaleBattlePanel", 1);
        }
        if (Preferences.Instance.Level >= 25 && Preferences.Instance.Level <= 36)
        {
            PlayerPrefs.SetInt("CombatFieldPanel", 1);
        }

        Application.LoadLevel("MainMenu");

	}

	public void btn_MainMenu()
	{
        Time.timeScale = 1;
        StartCoroutine(lateMenuGo());

    }
    IEnumerator lateMenuGo()
    {
        yield return new WaitForSeconds(0.5f);
        Application.LoadLevel("MainMenu");
    }
	public void btn_Replay()
	{
         //WCSdk.Instance.ShowSequence(0);
        Application.LoadLevel("LoadingScene");

	}
	public void btn_pause()
	{
       // AdsManager.instance.ShowRewardedVideo();
        Time.timeScale = 0;
		pnGamePlay.SetActive (false);
		pnPause.SetActive (true);
//		SabloSdk.Instance.ShowBanner ();
//		SabloSdk.Instance.ShowSequence(2);

	}

	public void btn_resume()
	{
		Time.timeScale = 1;
		pnGamePlay.SetActive (true);
		pnPause.SetActive (false);
//		SabloSdk.Instance.HideBanner ();

	}
    public void btn_moreFun()
    {
//		Application.OpenURL(SabloSdk.Instance.MoreFunURL());
    }
			
	public void GameOver()
	{
		if (!isOver)
			isOver = true;
		else
			return;
		Debug.Log ("Game Over Fun");
		if (isCompleted)
			return;
		StartCoroutine (waitGameOver());
	}

	public void LevelComplete()
	{
		if (!isCompleted)
			isCompleted = true;
		else
			return;
		Debug.Log ("Level Complete Fun");
		if (isOver)
			return;
		StartCoroutine (waitlevelComplete());
	}

	IEnumerator waitlevelComplete()
	{
        Debug.Log("Level Complete");
        if (Preferences.Instance.Level == 14)
        {
            PlayerPrefs.SetInt("level14", 1);
        }

       else if (Preferences.Instance.Level == 15)
        {
            PlayerPrefs.SetInt("level15", 1);
        }

        else if (Preferences.Instance.Level == 16)
        {
            PlayerPrefs.SetInt("level16", 1);
        }
        else if (Preferences.Instance.Level == 17)
        {
            PlayerPrefs.SetInt("level17", 1);
        }

        else if (Preferences.Instance.Level == 18)
        {
            PlayerPrefs.SetInt("level18", 1);
        }
        else if (Preferences.Instance.Level == 19)
        {
            PlayerPrefs.SetInt("level19", 1);
        }
        else if (Preferences.Instance.Level == 20)
        {
            PlayerPrefs.SetInt("level20", 1);
        }
        else if (Preferences.Instance.Level == 21)
        {
            PlayerPrefs.SetInt("level21", 1);
        }
        else if (Preferences.Instance.Level == 22)
        {
            PlayerPrefs.SetInt("level22", 1);
        }
        else if (Preferences.Instance.Level == 23)
        {
            PlayerPrefs.SetInt("level23", 1);
        }
        else if (Preferences.Instance.Level == 24)
        {
            PlayerPrefs.SetInt("level24", 1);
        }

        else if (Preferences.Instance.Level == 26)
        {
            PlayerPrefs.SetInt("level26", 1);
        }
        else if (Preferences.Instance.Level == 27)
        {
            PlayerPrefs.SetInt("level27", 1);
        }
        else if (Preferences.Instance.Level == 28)
        {
            PlayerPrefs.SetInt("level28", 1);
        }
        else if (Preferences.Instance.Level == 29)
        {
            PlayerPrefs.SetInt("level29", 1);
        }
        else if (Preferences.Instance.Level == 30)
        {
            PlayerPrefs.SetInt("level30", 1);
        }
        else if (Preferences.Instance.Level == 31)
        {
            PlayerPrefs.SetInt("level31", 1);
        }
        else if (Preferences.Instance.Level == 32)
        {
            PlayerPrefs.SetInt("level32", 1);
        }

        else if (Preferences.Instance.Level == 33)
        {
            PlayerPrefs.SetInt("level33", 1);
        }

        else if (Preferences.Instance.Level == 34)
        {
            PlayerPrefs.SetInt("level34", 1);
        }
        else if (Preferences.Instance.Level == 35)
        {
            PlayerPrefs.SetInt("level35", 1);
        }
        else if (Preferences.Instance.Level == 36)
        {
            PlayerPrefs.SetInt("level36", 1);
        }
        //		SabloSdk.Instance.ShowBanner ();
        if (Preferences.Instance.Level == Preferences.Instance.LevelUnlock && Preferences.Instance.LevelUnlock < levelManager.Levels.Length)
        {
            Preferences.Instance.LevelUnlock++;
        }
//        Time.timeScale = 0;
		pnGamePlay.SetActive(false);
        pnLevelComplete.SetActive(true);
		if (Preferences.Instance.Level >= levelManager.Levels.Length)
        {
            GameComp.SetActive(true);
            levelComp.SetActive(false);
            nextButton.SetActive(false);
        }
        AdsManager.instance.ShowInterstitial();
        yield return new WaitForSeconds (2f);
//		SabloSdk.Instance.ShowSequence(2);
        AudioListener.pause = true;
	}

    IEnumerator waitGameOver()
    {
        //		SabloSdk.Instance.ShowBanner ();
        yield return new WaitForSeconds(5f);
        AdsManager.instance.ShowInterstitial();
        pnGameOver.SetActive(true);
		pnGamePlay.SetActive(false);
        Time.timeScale = 0;
//		SabloSdk.Instance.ShowSequence(2);

    }

    public void LevelSkip()
    {

        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            AdsNotAvailable.SetActive(true);
        }
        else
        {
            if (Advertisements.Instance.IsRewardVideoAvailable())
            {
                PlayerPrefs.SetInt("SkipLevel", 1);
                AdsManager.instance.ShowInterstitial();
            }
            else
            {
                AdsNotAvailable.SetActive(true);
            }

        }
    }

    public void SettingOn()
    {
        settingPanel.SetActive(true);
    }

    public void SetingBack()
    {
        settingPanel.SetActive(false);
        customizationPanel.SetActive(false);
    }

    public void SoundOn()
    {
        Music.SetActive(true);
    }

    public void SoundOff()
    {
        Music.SetActive(false);
    }

    public void CustomizationOn()
    {
        settingPanel.SetActive(false);
        customizationPanel.SetActive(true);
    }

    public void CustomizationSave()
    {
        settingPanel.SetActive(true);
        customizationPanel.SetActive(false);
    }


    public void AdsNotAvai()
    {
        AdsNotAvailable.SetActive(false);
    }



}