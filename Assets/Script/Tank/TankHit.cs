using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankHit : MonoBehaviour {

    public float m_TankHitDamage = 5f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        TankHealth targetHealth = collision.gameObject.GetComponent<TankHealth>();
        targetHealth.TakeDamge(m_TankHitDamage);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
