using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankFire : MonoBehaviour {
    public GameObject m_ShellLight;
    public GameObject m_ShellMedium;
    public GameObject m_ShellHeavy;
    public GameObject m_Rocket;
    private bool canShoot;
    void Start()
    {
        canShoot = true;
    }

    public void Fire()
    {
        if(canShoot)
        {
            StartCoroutine(ShootGun());
        }
       
    }

    public IEnumerator ShootGun()
    {
        GameObject findControlGameObject = GameObject.Find("GameControl");
        TankFireSelection setFire = findControlGameObject.transform.GetComponent<TankFireSelection>();
        Debug.Log(setFire.gunSelected);
        if (setFire.gunSelected == "Gun1"|| setFire.gunSelected == "")
        {
            GameObject lightShellPrefab = Instantiate(m_ShellLight, this.gameObject.transform.GetChild(0).position, this.gameObject.transform.GetChild(0).rotation);
            canShoot = false;
            yield return new WaitForSeconds(0.4f);
            canShoot = true;
        }else if(setFire.gunSelected == "Gun2")
        {
            GameObject mediumShellPrefab = Instantiate(m_ShellMedium, this.gameObject.transform.GetChild(0).position, this.gameObject.transform.GetChild(0).rotation);
            canShoot = false;
            yield return new WaitForSeconds(0.5f);
            canShoot = true;
        }
        else if (setFire.gunSelected == "Gun3")
        {
            GameObject heavyShellPrefab = Instantiate(m_ShellHeavy, this.gameObject.transform.GetChild(0).position, this.gameObject.transform.GetChild(0).rotation);
            canShoot = false;
            yield return new WaitForSeconds(0.6f);
            canShoot = true;
        }
        else if (setFire.gunSelected == "Gun4")
        {
            GameObject RockePrefab = Instantiate(m_Rocket, this.gameObject.transform.GetChild(0).position, this.gameObject.transform.GetChild(0).rotation);
            canShoot = false;
            yield return new WaitForSeconds(1f);
            canShoot = true;
        }

    }


	
	// Update is called once per frame
	void Update () {
		
	}
}
