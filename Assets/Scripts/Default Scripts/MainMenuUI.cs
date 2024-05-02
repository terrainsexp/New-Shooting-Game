using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using Soomla.Store;


public class MainMenuUI : MonoBehaviour
{

    // Use this for initialization
    public AudioClip BtnClickClip = null;
    AudioSource srcBtnClick;

    public GameObject MainmenuPanel;
    public GameObject ShopPanel;
    public GameObject InventoryPanel;
    public GameObject SelectTeamPanel;
    public GameObject DaiyBonusPanel;
    public GameObject MissionsPanel;


    public GameObject EliteMissionPanel;
    public GameObject RoyaleBattlePanel;
    public GameObject CombatFieldPanel;

    public GameObject CoinPanel;
    public GameObject HealthPanel;
    public GameObject GrenadePanel;

    public GameObject Ak47InfoPanel;
    public GameObject PistolInfoPanel;
    public GameObject M416InfoPanel;
    public GameObject MachineGunInfoPanel;
    public GameObject ShotGunInfoPanel;
    public GameObject SniperInfoPanel;

    public GameObject PistolBuy;
    public GameObject M416Buy;
    public GameObject MachineGunBuy;
    public GameObject ShotGunBuy;
    public GameObject SniperBuy;

    public GameObject PistolBuybt;
    public GameObject M416Buybt;
    public GameObject MachineGunBuybt;
    public GameObject ShotGunbt;
    public GameObject SniperBuybt;

    public GameObject PistolEquiped;
    public GameObject M416Equiped;
    public GameObject MachineGunEquiped;
    public GameObject ShotGunEquiped;
    public GameObject SniperEquiped;

    public Text TotalCoins;
    public Text TotalHealth;
    public Text TotalGrenades;

    public GameObject settingPanel;
    public GameObject customizationPanel;
    public GameObject Music;

    public GameObject InfoPanel1;
    public GameObject InfoPanel2;
    public GameObject InfoPanel3;

    public GameObject GreenHole1;
    public GameObject GreenHole2;
    public GameObject GreenHole3;
    public GameObject GreenHole4;
    public GameObject GreenHole5;

    public GameObject Character1;
    public GameObject Character2;
    public GameObject Character3;
    public GameObject Character4;
    public GameObject Character5;

    public GameObject MainMenuCharacter1;
    public GameObject MainMenuCharacter2;
    public GameObject MainMenuCharacter3;
    public GameObject MainMenuCharacter4;
    public GameObject MainMenuCharacter5;

    public GameObject iInfoPanel;
    public GameObject Watch3DoBjectsCamera;
    public GameObject ADSNotAvailable;
    public GameObject InternetNotConnected;
    public GameObject ThousandCoinsGets;
    public GameObject OneHealthGets;
    public GameObject OneGrenadeGets;
    public GameObject MainMenuBackBt;
    public GameObject ShopBackBt;
    public GameObject Play;
    public GameObject TotalCharacters;
    public static int numbers1 = 1;
    public static MainMenuUI instance;
    public static bool firstLoad = false;
    void Start()
    {
        instance = this;

        Cursor.lockState = CursorLockMode.None;
        srcBtnClick = gameObject.AddComponent<AudioSource>();
        Watch3DoBjectsCamera.SetActive(true);
       // AdsManager.instance.ShowBanner();
        AudioListener.pause = false;
        Time.timeScale = 1;
        Preferences.Instance.RateUs++;
        Debug.Log(Preferences.Instance.RateUs);
        if (Preferences.Instance.RateUs % 8 == 0)
        {
            print("in rateus");
            // rate_Us_Panel.SetActive(true);

        }

        //		SabloSdk.Instance.LogScreen("Main Menu");
        //
        //		SabloSdk.Instance.ShowBanner ();
    }

    private void Update()
    {

        if (ShopPanel.activeInHierarchy == true)
        {
            MainMenuBackBt.SetActive(false);
            ShopBackBt.SetActive(true);
        }
        else
        {
            MainMenuBackBt.SetActive(true);
            ShopBackBt.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Pistol") == 1)
        {
            PistolBuy.SetActive(false);
            PistolBuybt.SetActive(false);
            PistolEquiped.SetActive(true);
        }

        if (PlayerPrefs.GetInt("M146") == 1)
        {
            M416Buy.SetActive(false);
            M416Buybt.SetActive(false);
            M416Equiped.SetActive(true);
        }

        if (PlayerPrefs.GetInt("MachineGun") == 1)
        {
            MachineGunBuy.SetActive(false);
            MachineGunBuybt.SetActive(false);
            MachineGunEquiped.SetActive(true);
        }

        if (PlayerPrefs.GetInt("ShotGun") == 1)
        {
            ShotGunBuy.SetActive(false);
            ShotGunbt.SetActive(false);
            ShotGunEquiped.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Sniper") == 1)
        {
            SniperBuy.SetActive(false);
            SniperBuybt.SetActive(false);
            SniperEquiped.SetActive(true);
        }

        if (PlayerPrefs.GetInt("EliteMissionPanel") == 1)
        {
            EliteMissionPan();
            PlayerPrefs.SetInt("EliteMissionPanel", 0);
        }

        if (PlayerPrefs.GetInt("RoyaleBattlePanel") == 1)
        {
            RoyaleBattlePan();
            PlayerPrefs.SetInt("RoyaleBattlePanel", 0);
        }

        if (PlayerPrefs.GetInt("CombatFieldPanel") == 1)
        {
            CombatFieldPan();
            PlayerPrefs.SetInt("CombatFieldPanel", 0);
        }

        TotalCoins.text = PlayerPrefs.GetInt("score").ToString();
        TotalGrenades.text = PlayerPrefs.GetInt("grenade").ToString();
        TotalHealth.text = PlayerPrefs.GetInt("GiveHealth").ToString();

    }

    public void BacktoMainMenuPan()
    {
        if (MainmenuPanel.activeInHierarchy == true)
        {
            Debug.Log("quite");
            Application.Quit();
        }
        else
        {
            AdsManager.instance.ShowInterstitial();
            MainmenuPanel.SetActive(true);
            TotalCharacters.SetActive(true);
            Watch3DoBjectsCamera.SetActive(true);
            MissionsPanel.SetActive(false);
            ShopPanel.SetActive(false);
            InventoryPanel.SetActive(false);
            SelectTeamPanel.SetActive(false);
            DaiyBonusPanel.SetActive(false);
        }
        
    }

    public void ShopBacktoMainMenuPan()
    {
        Watch3DoBjectsCamera.SetActive(true);
        ShopPanel.SetActive(false);
    }

    public void ShopPan()
    {
        Watch3DoBjectsCamera.SetActive(false);
        TotalCharacters.SetActive(false);
        ShopPanel.SetActive(true);
        InventoryPanel.SetActive(false);
        SelectTeamPanel.SetActive(false);
    }


    public void CoinPan()
    {
        ShopPanel.SetActive(true);
        Watch3DoBjectsCamera.SetActive(false);
        CoinPanel.SetActive(true);
        HealthPanel.SetActive(false);
        GrenadePanel.SetActive(false);
        TotalCharacters.SetActive(false);
    }


    public void HealthPan()
    {
        ShopPanel.SetActive(true);
        Watch3DoBjectsCamera.SetActive(false);
        CoinPanel.SetActive(false);
        HealthPanel.SetActive(true);
        GrenadePanel.SetActive(false);
        TotalCharacters.SetActive(false);

    }

    public void GrenadePan()
    {
        ShopPanel.SetActive(true);
        Watch3DoBjectsCamera.SetActive(false);
        CoinPanel.SetActive(false);
        HealthPanel.SetActive(false);
        GrenadePanel.SetActive(true);
        TotalCharacters.SetActive(false);
    }


    public void InventoryPan()
    {
        MainmenuPanel.SetActive(false);
        TotalCharacters.SetActive(false);
        ShopPanel.SetActive(false);
        InventoryPanel.SetActive(true);
        SelectTeamPanel.SetActive(false);
    }



    public void SelectTeamPan()
    {
        MainmenuPanel.SetActive(false);
        ShopPanel.SetActive(false);
        InventoryPanel.SetActive(false);
        SelectTeamPanel.SetActive(true);
        TotalCharacters.SetActive(false);
    }


    public void DailyBonusPan()
    {
        AdsManager.instance.ShowInterstitial();
        TotalCharacters.SetActive(false);
        MainmenuPanel.SetActive(false);
        ShopPanel.SetActive(false);
        InventoryPanel.SetActive(false);
        SelectTeamPanel.SetActive(false);
        DaiyBonusPanel.SetActive(true);
    }


    public void EliteMissionPan()
    {
        MainmenuPanel.SetActive(false);
        Play.SetActive(false);
        MissionsPanel.SetActive(true);
        EliteMissionPanel.SetActive(true);
        RoyaleBattlePanel.SetActive(false);
        CombatFieldPanel.SetActive(false);
    }

    public void RoyaleBattlePan()
    {
        MainmenuPanel.SetActive(false);
        MissionsPanel.SetActive(true);
        Play.SetActive(false);
        EliteMissionPanel.SetActive(false);
        RoyaleBattlePanel.SetActive(true);
        CombatFieldPanel.SetActive(false);
    }


    public void CombatFieldPan()
    {
        MainmenuPanel.SetActive(false);
        MissionsPanel.SetActive(true);
        Play.SetActive(false);
        EliteMissionPanel.SetActive(false);
        RoyaleBattlePanel.SetActive(false);
        CombatFieldPanel.SetActive(true);
    }

    public void btn_Play()
    {
        PlaySound();
        Application.LoadLevel("LevelSelection");
    }
    public void btn_RemoveAds()
    {
        PlaySound();
        //StoreInventory.BuyItem(GameObject.FindObjectOfType<SoomlaFoo>().purchaseIDs[0]);
    }
    public void btn_More_Fun()
    {
        PlaySound();
        Application.OpenURL("https://play.google.com/store/apps/developer?id=New+shooting+games+2020");

    }

    public void btn_rate_Now()
    {
        PlaySound();
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.nsg.free.fire.battleground.fps.gun.shooting.games");


    }
    public void PlaySound()
    {
        srcBtnClick.clip = BtnClickClip;
        srcBtnClick.Play();

    }

    public void Ak47Pan()
    {
        Ak47InfoPanel.SetActive(true);
        MachineGunInfoPanel.SetActive(false);
        PistolInfoPanel.SetActive(false);
        M416InfoPanel.SetActive(false);
        ShotGunInfoPanel.SetActive(false);
        SniperInfoPanel.SetActive(false);
    }

    public void PistolPan()
    {
        Ak47InfoPanel.SetActive(false);
        MachineGunInfoPanel.SetActive(false);
        PistolInfoPanel.SetActive(true);
        M416InfoPanel.SetActive(false);
        ShotGunInfoPanel.SetActive(false);
        SniperInfoPanel.SetActive(false);
    }

    public void M416Pan()
    {
        Ak47InfoPanel.SetActive(false);
        MachineGunInfoPanel.SetActive(false);
        PistolInfoPanel.SetActive(false);
        M416InfoPanel.SetActive(true);
        ShotGunInfoPanel.SetActive(false);
        SniperInfoPanel.SetActive(false);
    }

    public void MachineGunPan()
    {
        Ak47InfoPanel.SetActive(false);
        MachineGunInfoPanel.SetActive(true);
        PistolInfoPanel.SetActive(false);
        M416InfoPanel.SetActive(false);
        ShotGunInfoPanel.SetActive(false);
        SniperInfoPanel.SetActive(false);
    }

    public void ShotGunnPan()
    {
        Ak47InfoPanel.SetActive(false);
        MachineGunInfoPanel.SetActive(false);
        PistolInfoPanel.SetActive(false);
        M416InfoPanel.SetActive(false);
        ShotGunInfoPanel.SetActive(true);
        SniperInfoPanel.SetActive(false);
    }

    public void SniperPan()
    {
        Ak47InfoPanel.SetActive(false);
        MachineGunInfoPanel.SetActive(false);
        PistolInfoPanel.SetActive(false);
        M416InfoPanel.SetActive(false);
        ShotGunInfoPanel.SetActive(false);
        SniperInfoPanel.SetActive(true);
    }

    public void SettingOn()
    {

        PlaySound();
        TotalCharacters.SetActive(false);
        Watch3DoBjectsCamera.SetActive(false);
        settingPanel.SetActive(true);
    }

    public void SetingBack()
    {
        PlaySound();
        if (ShopPanel.activeInHierarchy == true)
        {
            Watch3DoBjectsCamera.SetActive(false);
            TotalCharacters.SetActive(false);
        }
        else
        {
            Watch3DoBjectsCamera.SetActive(true);
            TotalCharacters.SetActive(true);
        }
        AdsManager.instance.ShowInterstitial();
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
        PlaySound();
        settingPanel.SetActive(true);
        customizationPanel.SetActive(false);
    }

    public void ForwareCharacterCheck(int value)
    {
        numbers1 += value;
        if (numbers1 >= 5)
        {
            numbers1 = 5;
        }

        if (numbers1 == 1)
        {
            Character1.SetActive(true);
            GreenHole1.SetActive(true);

            InfoPanel1.SetActive(true);
            InfoPanel2.SetActive(false);
            InfoPanel3.SetActive(false);

            Character2.SetActive(false);
            GreenHole2.SetActive(false);

            Character3.SetActive(false);
            GreenHole3.SetActive(false);

            Character4.SetActive(false);
            GreenHole4.SetActive(false);

            Character5.SetActive(false);
            GreenHole5.SetActive(false);
        }

        if (numbers1 == 2)
        {

            Character1.SetActive(false);
            GreenHole1.SetActive(false);

            InfoPanel1.SetActive(false);
            InfoPanel2.SetActive(true);
            InfoPanel3.SetActive(false);

            Character2.SetActive(true);
            GreenHole2.SetActive(true);

            Character3.SetActive(false);
            GreenHole3.SetActive(false);

            Character4.SetActive(false);
            GreenHole4.SetActive(false);

            Character5.SetActive(false);
            GreenHole5.SetActive(false);
        }

        if (numbers1 == 3)
        {
            Character1.SetActive(false);
            GreenHole1.SetActive(false);

            InfoPanel1.SetActive(false);
            InfoPanel2.SetActive(false);
            InfoPanel3.SetActive(true);

            Character2.SetActive(false);
            GreenHole2.SetActive(false);


            Character3.SetActive(true);
            GreenHole3.SetActive(true);

            Character4.SetActive(false);
            GreenHole4.SetActive(false);

            Character5.SetActive(false);
            GreenHole5.SetActive(false);
        }

        if (numbers1 == 4)
        {
            Character1.SetActive(false);
            GreenHole1.SetActive(false);

            InfoPanel1.SetActive(false);
            InfoPanel2.SetActive(false);
            InfoPanel3.SetActive(true);

            Character2.SetActive(false);
            GreenHole2.SetActive(false);

            Character3.SetActive(false);
            GreenHole3.SetActive(false);

            Character4.SetActive(true);
            GreenHole4.SetActive(true);

            Character5.SetActive(false);
            GreenHole5.SetActive(false);
        }

        if (numbers1 == 5)
        {
            Character1.SetActive(false);
            GreenHole1.SetActive(false);

            InfoPanel1.SetActive(false);
            InfoPanel2.SetActive(false);
            InfoPanel3.SetActive(true);

            Character2.SetActive(false);
            GreenHole2.SetActive(false);

            Character3.SetActive(false);
            GreenHole3.SetActive(false);

            Character4.SetActive(false);
            GreenHole4.SetActive(false);

            Character5.SetActive(true);
            GreenHole5.SetActive(true);
        }



    }

    public void BackwardCharacterCheck(int value)
    {
        numbers1 -= value;
        if (numbers1 <= 1)
        {
            numbers1 = 1;
        }

        if (numbers1 == 1)
        {

            Character1.SetActive(true);
            GreenHole1.SetActive(true);

            Character2.SetActive(false);
            GreenHole2.SetActive(false);

            InfoPanel1.SetActive(true);
            InfoPanel2.SetActive(false);
            InfoPanel3.SetActive(false);

            Character3.SetActive(false);
            GreenHole3.SetActive(false);

            Character4.SetActive(false);
            GreenHole4.SetActive(false);

            Character5.SetActive(false);
            GreenHole5.SetActive(false);
        }

        if (numbers1 == 2)
        {
            Character1.SetActive(false);
            GreenHole1.SetActive(false);

            InfoPanel1.SetActive(false);
            InfoPanel2.SetActive(true);
            InfoPanel3.SetActive(false);

            Character2.SetActive(true);
            GreenHole2.SetActive(true);

            Character3.SetActive(false);
            GreenHole3.SetActive(false);

            Character4.SetActive(false);
            GreenHole4.SetActive(false);

            Character5.SetActive(false);
            GreenHole5.SetActive(false);
        }
        if (numbers1 == 3)
        {

            Character1.SetActive(false);
            GreenHole1.SetActive(false);

            InfoPanel1.SetActive(false);
            InfoPanel2.SetActive(false);
            InfoPanel3.SetActive(true);

            Character2.SetActive(false);
            GreenHole2.SetActive(false);

            Character3.SetActive(true);
            GreenHole3.SetActive(true);

            Character4.SetActive(false);
            GreenHole4.SetActive(false);

            Character5.SetActive(false);
            GreenHole5.SetActive(false);
        }

        if (numbers1 == 4)
        {
            Character1.SetActive(false);
            GreenHole1.SetActive(false);

            InfoPanel1.SetActive(false);
            InfoPanel2.SetActive(false);
            InfoPanel3.SetActive(true);

            Character2.SetActive(false);
            GreenHole2.SetActive(false);

            Character3.SetActive(false);
            GreenHole3.SetActive(false);

            Character4.SetActive(true);
            GreenHole4.SetActive(true);

            Character5.SetActive(false);
            GreenHole5.SetActive(false);
        }

        if (numbers1 == 5)
        {
            Character1.SetActive(false);
            GreenHole1.SetActive(false);

            InfoPanel1.SetActive(false);
            InfoPanel2.SetActive(false);
            InfoPanel3.SetActive(true);

            Character2.SetActive(false);
            GreenHole2.SetActive(false);

            Character3.SetActive(false);
            GreenHole3.SetActive(false);

            Character4.SetActive(false);
            GreenHole4.SetActive(false);

            Character5.SetActive(true);
            GreenHole5.SetActive(true);
        }

    }

    public void CharacterSelect()
    {
        if (Character1.activeInHierarchy == true)
        {
            MainMenuCharacter1.SetActive(true);
            MainMenuCharacter2.SetActive(false);
            MainMenuCharacter3.SetActive(false);
            MainMenuCharacter4.SetActive(false);
            MainMenuCharacter5.SetActive(false);

            PlayerPrefs.SetInt("Player1", 1);
            PlayerPrefs.SetInt("Player2", 0);
            PlayerPrefs.SetInt("Player3", 0);
            PlayerPrefs.SetInt("Player4", 0);
            PlayerPrefs.SetInt("Player5", 0);
        }

        if (Character2.activeInHierarchy == true)
        {
            MainMenuCharacter1.SetActive(false);
            MainMenuCharacter2.SetActive(true);
            MainMenuCharacter3.SetActive(false);
            MainMenuCharacter4.SetActive(false);
            MainMenuCharacter5.SetActive(false);

            PlayerPrefs.SetInt("Player1", 0);
            PlayerPrefs.SetInt("Player2", 1);
            PlayerPrefs.SetInt("Player3", 0);
            PlayerPrefs.SetInt("Player4", 0);
            PlayerPrefs.SetInt("Player5", 0);
        }

        if (Character3.activeInHierarchy == true)
        {
            MainMenuCharacter1.SetActive(false);
            MainMenuCharacter2.SetActive(false);
            MainMenuCharacter3.SetActive(true);
            MainMenuCharacter4.SetActive(false);
            MainMenuCharacter5.SetActive(false);

            PlayerPrefs.SetInt("Player1", 0);
            PlayerPrefs.SetInt("Player2", 0);
            PlayerPrefs.SetInt("Player3", 1);
            PlayerPrefs.SetInt("Player4", 0);
            PlayerPrefs.SetInt("Player5", 0);
        }

        if (Character4.activeInHierarchy == true)
        {
            MainMenuCharacter1.SetActive(false);
            MainMenuCharacter2.SetActive(false);
            MainMenuCharacter3.SetActive(false);
            MainMenuCharacter4.SetActive(true);
            MainMenuCharacter5.SetActive(false);

            PlayerPrefs.SetInt("Player1", 0);
            PlayerPrefs.SetInt("Player2", 0);
            PlayerPrefs.SetInt("Player3", 0);
            PlayerPrefs.SetInt("Player4", 1);
            PlayerPrefs.SetInt("Player5", 0);
        }

        if (Character5.activeInHierarchy == true)
        {
            MainMenuCharacter1.SetActive(false);
            MainMenuCharacter2.SetActive(false);
            MainMenuCharacter3.SetActive(false);
            MainMenuCharacter4.SetActive(false);
            MainMenuCharacter5.SetActive(true);

            PlayerPrefs.SetInt("Player1", 0);
            PlayerPrefs.SetInt("Player2", 0);
            PlayerPrefs.SetInt("Player3", 0);
            PlayerPrefs.SetInt("Player4", 0);
            PlayerPrefs.SetInt("Player5", 1);
        }

        BacktoMainMenuPan();
    }


    public void iInfoPanOn()
    {
        Watch3DoBjectsCamera.SetActive(false);
        iInfoPanel.SetActive(true);
        TotalCharacters.SetActive(false);
    }
    public void iInfoPanOff()
    {
        AdsManager.instance.ShowInterstitial();
        Watch3DoBjectsCamera.SetActive(true);
        iInfoPanel.SetActive(false);
        TotalCharacters.SetActive(true);
    }

    public void adnotavailable()
    {
        Watch3DoBjectsCamera.SetActive(false);
        TotalCharacters.SetActive(false);
        ADSNotAvailable.SetActive(true);
        InternetNotConnected.SetActive(false);
        ThousandCoinsGets.SetActive(false);
        OneHealthGets.SetActive(false);
        OneGrenadeGets.SetActive(false);
    }

    public void Thousndcoin()
    {
        Watch3DoBjectsCamera.SetActive(false);
        TotalCharacters.SetActive(false);
        ADSNotAvailable.SetActive(false);
        InternetNotConnected.SetActive(false);
        ThousandCoinsGets.SetActive(true);
        OneHealthGets.SetActive(false);
        OneGrenadeGets.SetActive(false);
    }

    public void OneHEALTH()
    {
        Watch3DoBjectsCamera.SetActive(false);
        TotalCharacters.SetActive(false);
        ADSNotAvailable.SetActive(false);
        InternetNotConnected.SetActive(false);
        ThousandCoinsGets.SetActive(false);
        OneHealthGets.SetActive(true);
        OneGrenadeGets.SetActive(false);
    }

    public void OneGrenade()
    {
        Watch3DoBjectsCamera.SetActive(false);
        TotalCharacters.SetActive(false);
        ADSNotAvailable.SetActive(false);
        InternetNotConnected.SetActive(false);
        ThousandCoinsGets.SetActive(false);
        OneHealthGets.SetActive(false);
        OneGrenadeGets.SetActive(true);
    }

    public void InternetnotAVAIL()
    {
        Watch3DoBjectsCamera.SetActive(false);
        TotalCharacters.SetActive(false);
        ADSNotAvailable.SetActive(false);
        InternetNotConnected.SetActive(true);
        ThousandCoinsGets.SetActive(false);
        OneHealthGets.SetActive(false);
        OneGrenadeGets.SetActive(false);
        Watch3DoBjectsCamera.SetActive(false);
    }

    public void backOffromPanel()
    {
        if (!ShopPanel.activeInHierarchy == true)
        {
            Watch3DoBjectsCamera.SetActive(true);
            TotalCharacters.SetActive(true);
        }
        
        ADSNotAvailable.SetActive(false);
        InternetNotConnected.SetActive(false);
        ThousandCoinsGets.SetActive(false);
        OneHealthGets.SetActive(false);
        OneGrenadeGets.SetActive(false);
    }
}