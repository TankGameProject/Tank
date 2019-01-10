using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankFireSelection : MonoBehaviour {
    public Transform[] buttonGun;
    public string gunSelected;
    public void SelectShell1()
    {
        buttonGun[0].localScale = new Vector3(1.2f,1.2f,1.2f);
        buttonGun[1].localScale = new Vector3(1f, 1f, 1f);
        buttonGun[2].localScale = new Vector3(1f, 1f, 1f);
        buttonGun[3].localScale = new Vector3(1f, 1f, 1f);
        buttonGun[4].localScale = new Vector3(1f, 1f, 1f);
        gunSelected = "Gun1";
        
    }

    public void SelectShell2()
    {
        buttonGun[1].localScale = new Vector3(1.2f, 1.2f, 1.2f);
        buttonGun[0].localScale = new Vector3(1f, 1f, 1f);
        buttonGun[2].localScale = new Vector3(1f, 1f, 1f);
        buttonGun[3].localScale = new Vector3(1f, 1f, 1f);
        buttonGun[4].localScale = new Vector3(1f, 1f, 1f);
        gunSelected = "Gun2";
        
    }

    public void SelectShell3()
    {
        buttonGun[2].localScale = new Vector3(1.2f, 1.2f, 1.2f);
        buttonGun[0].localScale = new Vector3(1f, 1f, 1f);
        buttonGun[1].localScale = new Vector3(1f, 1f, 1f);
        buttonGun[3].localScale = new Vector3(1f, 1f, 1f);
        buttonGun[4].localScale = new Vector3(1f, 1f, 1f);
        gunSelected = "Gun3";
        
    }

    public void SelectShell4()
    {
        buttonGun[3].localScale = new Vector3(1.2f, 1.2f, 1.2f);
        buttonGun[0].localScale = new Vector3(1f, 1f, 1f);
        buttonGun[1].localScale = new Vector3(1f, 1f, 1f);
        buttonGun[2].localScale = new Vector3(1f, 1f, 1f);
        buttonGun[4].localScale = new Vector3(1f, 1f, 1f);
        gunSelected = "Gun4";
        
    }

    public void SelectShell5()
    {
        buttonGun[4].localScale = new Vector3(1.2f, 1.2f, 1.2f);
        buttonGun[0].localScale = new Vector3(1f, 1f, 1f);
        buttonGun[1].localScale = new Vector3(1f, 1f, 1f);
        buttonGun[2].localScale = new Vector3(1f, 1f, 1f);
        buttonGun[3].localScale = new Vector3(1f, 1f, 1f);
        gunSelected = "Gun5";
        
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
