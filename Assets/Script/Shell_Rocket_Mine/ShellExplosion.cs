using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellExplosion : MonoBehaviour {
    //public LayerMask m_TankMask;
    public ParticleSystem m_ExplosionParticles;
    public AudioSource m_ExplosionAudio;
    //public float m_MaxDamage = 100f;
    public float m_ShellDamage = 10;
    public float m_ExplosionForce = 10f;
    public float m_MaxLifeTime = 2f;
    public float m_ExplosionRadius = 0f;
	// Use this for initialization
	private void Start () {
        gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up*m_ExplosionForce);
        Destroy(gameObject,m_MaxLifeTime);
	}


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position,m_ExplosionRadius,m_TankMask);
        //for(int i= 0; i< colliders.Length; i++)
        //{
        //    Rigidbody2D targetRigidbody = colliders[i].GetComponent<Rigidbody2D>();
        //    if (!targetRigidbody)
        //        continue;

        //    TankHealth targetHealth = targetRigidbody.GetComponent<TankHealth>();
        //    Debug.Log(targetRigidbody.name);
        //    if (!targetHealth)
        //        continue;

        //    targetHealth.TakeDamge(m_ShellDamage);

        //}

        if (collision.gameObject.layer == 8 || collision.gameObject.layer == 9)
        {
            TankHealth targetHealth = collision.GetComponent<TankHealth>();
            targetHealth.TakeDamge(m_ShellDamage);
            m_ExplosionParticles.transform.parent = null;
            m_ExplosionParticles.Play();
            m_ExplosionAudio.Play();
            Destroy(m_ExplosionParticles.gameObject, m_ExplosionParticles.main.duration);
            Destroy(gameObject);
        }
    }

    
    void Update () {
		
	}
}
