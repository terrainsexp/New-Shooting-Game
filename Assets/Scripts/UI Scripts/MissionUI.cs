using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MissionUI : MonoBehaviour 
{
    public Text txtMission;
    public GameObject panelMission;
    public string[] missions;

	// Use this for initialization
	void Start () 
    {
		panelMission.SetActive(true);
        txtMission.text = missions[Preferences.Instance.Level - 1];
	
	}


    public void btnCloseBriefing()
    {
        panelMission.SetActive(false);
    }
    public void btnOpenBriefing()
    {
        panelMission.SetActive(true);
    }
}
