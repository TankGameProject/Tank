using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusAddBlood : MonoBehaviour {

    public float bloodAdd = 20f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 8 || collision.gameObject.layer == 9)
        {
            TankHealth targetHealth = collision.GetComponent<TankHealth>();
            targetHealth.AddBlood(bloodAdd);
            Destroy(gameObject);
        }
        
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
