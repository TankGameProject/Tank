using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiTankChangeTexture : MonoBehaviour {
    public SpriteRenderer tankPlayer;
    public Image tankPicture;

    public void ChangeColorToGreen()
    {
        tankPlayer.GetComponent<SpriteRenderer>().color = Color.green;
        tankPicture.GetComponent<Image>().color = Color.green;
    }

    public void ChangeColorToRed()
    {
        tankPlayer.GetComponent<SpriteRenderer>().color = Color.red;
        tankPicture.GetComponent<Image>().color = Color.red;
    }

    public void ChangeColorToYellow()
    {
        tankPlayer.GetComponent<SpriteRenderer>().color = Color.yellow;
        tankPicture.GetComponent<Image>().color = Color.yellow;
    }

    public void ChangeColorToBlue()
    {
        tankPlayer.GetComponent<SpriteRenderer>().color = Color.blue;
        tankPicture.GetComponent<Image>().color = Color.blue;
    }

    public void ChangeColorToCyan()
    {
        tankPlayer.GetComponent<SpriteRenderer>().color = Color.cyan;
        tankPicture.GetComponent<Image>().color = Color.cyan;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
