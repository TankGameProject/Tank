using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankFuel : MonoBehaviour {

    public float m_StartingFuel = 100f;
    public Slider m_Slider;
    public Image m_FillImage;
    public Color m_FullFuelColor = Color.green;
    public Color m_ZeroFuelColor = Color.red;

    private float m_CurrentFuel;
    private bool m_Stay;
    private float m_DistanceTravel = 0f;
    private Vector3 m_LastPosition;

    private void OnEnable()
    {
        
        m_CurrentFuel = m_StartingFuel;
        m_Stay = false;
        SetFuelUI();
    }

    public void AddFuel(float amount)
    {
        if (m_CurrentFuel < 100f)
        {
            m_DistanceTravel -= amount;
            if (m_CurrentFuel > 100f)
            {
                m_CurrentFuel = 100f;
                m_DistanceTravel = 0f;
            }
        }
        SetFuelUI();
    }

    public void FuelUsage(float amount)
    {
        m_CurrentFuel =m_StartingFuel- Mathf.Round(amount);
        //Debug.Log(m_CurrentFuel);
        SetFuelUI();
        if (m_CurrentFuel <= 0f && !m_Stay)
        {
            OnStay();
        }
    }

    private void SetFuelUI()
    {
        m_Slider.value = m_CurrentFuel;
        m_FillImage.color = Color.Lerp(m_ZeroFuelColor, m_FullFuelColor, m_CurrentFuel / m_StartingFuel);
    }


    private void OnStay()
    {
        m_Stay = true;
        gameObject.GetComponent<TankMovementNormal>().m_Speed = 0f;
        //gameObject.SetActive(false);

    }
    // Use this for initialization
    void Start () {
        m_LastPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        m_DistanceTravel += Vector3.Distance(transform.position, m_LastPosition);
        //Debug.Log(m_DistanceTravel);
        m_LastPosition = transform.position;
        FuelUsage(m_DistanceTravel);

    }
}
