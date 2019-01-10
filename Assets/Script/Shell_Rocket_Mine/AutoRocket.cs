using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRocket : MonoBehaviour {
    GameObject target;
    public GameObject explosion;
    public float rotationSpeed = 10f;
    public float m_RocketDamage = 30f;

    Quaternion rotateToTarget;
    Vector3 dir;
    Vector3 dirOfRocket;

    Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        target = GameObject.Find("SimpleEnemy");
        rb = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
        dirOfRocket = transform.TransformDirection(Vector3.up).normalized;
        //Debug.Log(dirOfRocket.x+"/"+dirOfRocket.y+"/"+dirOfRocket.z);
        //Debug.Log(transform.rotation.z+"aa"+transform.rotation.y+"aa"+transform.rotation.z);
        dir = (target.transform.position - transform.position).normalized;

        //Debug.Log(dir.x+"/"+dir.y+"/"+dir.z);
        float angle = Vector3.Angle(dirOfRocket,dir);
        //Debug.Log(angle);
        //Vector3 finalDir = Vector3.RotateTowards(transform.up,target.transform.position,rotationSpeed*Time.deltaTime,0f);
        //float angledir = Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg;
        //float angledidOfRocket = Mathf.Atan2(dirOfRocket.x,dirOfRocket.y) * Mathf.Rad2Deg;
        Debug.Log(angle);
        rotateToTarget = Quaternion.AngleAxis(angle, Vector3.forward);
        //Debug.Log(rotateToTarget.x+"-"+rotateToTarget.y+"-"+rotateToTarget.z);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotateToTarget, Time.deltaTime * rotationSpeed);
        
        rb.velocity = new Vector2(dir.x * 2, dir.y * 2);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.layer == 9)
        {
            TankHealth targetHealth = collision.GetComponent<TankHealth>();
            Instantiate(explosion, transform.position, Quaternion.identity);
            
            targetHealth.TakeDamge(m_RocketDamage);
            Destroy(this.gameObject);
        }
        
    }
}
