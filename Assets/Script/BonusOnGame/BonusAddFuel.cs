using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusAddFuel : MonoBehaviour {

    public float FuelAdd = 20f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8 || collision.gameObject.layer == 9)
        {
            TankFuel targetHealth = collision.GetComponent<TankFuel>();
            targetHealth.AddFuel(FuelAdd);
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
