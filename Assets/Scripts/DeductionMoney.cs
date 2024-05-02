﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeductionMoney : MonoBehaviour
{

   
    int Grenade;

 
    public bool isGrenade;
    public bool isHealth;
    public bool isGunPanel;


   
    public GameObject GrenadesPanel;
    public GameObject HealthPanel;
    public GameObject GunPanel;

    int coin;
    public static DeductionMoney instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        
    }

    // Update is called once per frame
    void Update()
    {
       
       if (GrenadesPanel.activeInHierarchy == true)
        {
            isGrenade = true;
            isGunPanel = false;
            isHealth = false;
        }
        else if (HealthPanel.activeInHierarchy == true)
        {
            isHealth = true;
            isGrenade = false;
            isGunPanel = false;
        }
       else if (GunPanel.activeInHierarchy == true)
        {
            isGunPanel = true;
            isHealth = false;
            isGrenade = false;
        }
        else {
           
            isGrenade = false;
            isHealth = false;
            isGunPanel = false;
        }

        if (PlayerPrefs.GetInt("score") <= 0)
        {

            PlayerPrefs.SetInt("score", 0);
        }
    }

    public void DeductCoin (int value)
    {

        coin = PlayerPrefs.GetInt("score");

            
            if (isGrenade)
            {

               
                if (value == 1000)
                {
                    if ( PlayerPrefs.GetInt("score") >= 1000)
                    {
                        coin -= value;
                        GiveGrenade(2);
                    }
                        
                }

                if (value == 2000)
                {

                    if ( PlayerPrefs.GetInt("score") >= 2000)
                    {
                        coin -= value;
                        GiveGrenade(3);
                    }
                      

                }


                if (value == 3000)
                {

                    if (PlayerPrefs.GetInt("score") >= 3000)
                    {
                        coin -= value;
                        GiveGrenade(4);
                    }
                   
                }
            }

            if (isHealth)
            {
             
                
                if (value == 1000)
                {

                    if (PlayerPrefs.GetInt("score") >= 1000)
                    {
                        coin -= value;
                        TransferHealth(2);
                    }
                }

                if (value == 2000)
                {
                    if (PlayerPrefs.GetInt("score") >= 2000)
                    {
                        coin -= value;
                        TransferHealth(3);
                    }
                }

                if (value == 3000)
                {

                    if (PlayerPrefs.GetInt("score") >= 3000)
                    {
                        coin -= value;
                        TransferHealth(4);
                    }
                }
            }



        if (isGunPanel)
        {

            if (value == 1000)
            {
                if (PlayerPrefs.GetInt("score") >= 1000)
                {
                    coin -= value;
                    PlayerPrefs.SetInt("Pistol", 1);
                }
            }
            if (value == 2000)
            {

                if (PlayerPrefs.GetInt("score") >= 2000)
                {
                    coin -= value;
                    PlayerPrefs.SetInt("M146", 1);
                }
            }

            if (value == 3000)
            {
                if (PlayerPrefs.GetInt("score") >= 3000)
                {
                    coin -= value;
                    PlayerPrefs.SetInt("MachineGun", 1);
                }
            }

            if (value == 4000)
            {
                if (PlayerPrefs.GetInt("score") >= 4000)
                {
                    coin -= value;
                    PlayerPrefs.SetInt("ShotGun", 1);
                }
            }

            if (value == 5000)
            {

                if (PlayerPrefs.GetInt("score") >= 5000)
                {
                    coin -= value;
                    PlayerPrefs.SetInt("Sniper", 1);
                }
            }
        }


        PlayerPrefs.SetInt("score", coin);

       
       
    }

   
   public void GiveCoin(int value)
    {
        if (PlayerPrefs.GetInt("score") != null)
        {
            int getscore = PlayerPrefs.GetInt("score");

            getscore += value;

            PlayerPrefs.SetInt("score", getscore);
        }
        else
        {
            PlayerPrefs.SetInt("score", value);
        }
    }

    public void TransferHealth(int value)
    {
        if (PlayerPrefs.GetInt("GiveHealth") != null)
        {
            int totalhealthgive;

            totalhealthgive = PlayerPrefs.GetInt("GiveHealth");

            totalhealthgive += value;

            PlayerPrefs.SetInt("GiveHealth", totalhealthgive);
        }
        else
        {
            PlayerPrefs.SetInt("GiveHealth", value);
        }
    }

    public void GiveGrenade(int value2)
    {

        if (PlayerPrefs.GetInt("grenade")!= null)
        {
            Grenade = PlayerPrefs.GetInt("grenade");
            Grenade += value2;
            PlayerPrefs.SetInt("grenade", Grenade);
        }
        else
        {
            Grenade += value2;
            PlayerPrefs.SetInt("grenade", Grenade);
        }
    }

    public void WatchAddforCoin()
    {
        PlayerPrefs.SetInt("WatchaddCoin", 1);
        AdsManager.instance.ShowRewardedVideo();
    }

    public void WatchAddforHealth()
    {
        PlayerPrefs.SetInt("WatchaddHealth", 1);
        AdsManager.instance.ShowRewardedVideo();
    }

    public void WatchAddforGrendae()
    {
        PlayerPrefs.SetInt("WatchaddGrenade", 1);
        AdsManager.instance.ShowRewardedVideo();
    }

    public void ShowAds()
    {
        AdsManager.instance.ShowRewardedVideo();
    }
}
