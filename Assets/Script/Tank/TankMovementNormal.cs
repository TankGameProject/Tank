using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovementNormal : MonoBehaviour
{
    public Joystick joystick;
    public Transform joystickOriginal;

    public int m_PlayerNumber = 1;
    public float m_Speed = 1f;
    //public float m_TurnSpeed = 1f;
    public AudioSource m_MovementAudio;
    public AudioClip m_EngineIdling;
    public AudioClip m_EngineDriving;
    public float m_PitchRange = 0.2f;

    private string m_MovementAxisName;
    private string m_TurnAxisName;
    private Rigidbody2D m_Rigidbody;
    private float m_MovementInputVertical;
    private float m_TurnInputHorizontal;
    private float m_OriginalPitch;


    private void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
        Debug.Log(m_Rigidbody.rotation);
    }

    private void OnEnable()
    {
        m_Rigidbody.isKinematic = false;
        m_MovementInputVertical = 0f;
        m_TurnInputHorizontal = 0f;
    }

    private void OnDisable()
    {
        m_Rigidbody.isKinematic = true;
    }
    // Use this for initialization
    private void Start()
    {
        m_MovementAxisName = "Vertical" + m_PlayerNumber;
        m_TurnAxisName = "Horizontal" + m_PlayerNumber;
        m_OriginalPitch = m_MovementAudio.pitch;
    }

    // Update is called once per frame
    private void Update()
    {
        m_MovementInputVertical = joystick.Vertical;
        m_TurnInputHorizontal = joystick.Horizontal;
        EngineAudio();
    }

    private void EngineAudio()
    {
        if (Mathf.Abs(m_MovementInputVertical) < 0.1f && Mathf.Abs(m_TurnInputHorizontal) < 0.1f)
        {
            if (m_MovementAudio.clip == m_EngineDriving)
            {
                m_MovementAudio.clip = m_EngineIdling;
                m_MovementAudio.pitch = Random.Range(m_OriginalPitch - m_PitchRange, m_OriginalPitch + m_PitchRange);
                m_MovementAudio.Play();
            }
        }
        else
        {
            if (m_MovementAudio.clip == m_EngineIdling)
            {
                m_MovementAudio.clip = m_EngineDriving;
                m_MovementAudio.pitch = Random.Range(m_OriginalPitch - m_PitchRange, m_OriginalPitch + m_PitchRange);
                m_MovementAudio.Play();
            }
        }
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        //vector and m_Speed
        //Vector2 movementV = transform.up * m_MovementInputVertical * m_Speed * Time.deltaTime;
        //Vector2 movementH = transform.right * m_TurnInputHorizontal * m_Speed * Time.deltaTime;

        //Vector without m_Speed
        Vector2 movementV = transform.up * m_MovementInputVertical* Time.deltaTime;
        Vector2 movementH = transform.right * m_TurnInputHorizontal* Time.deltaTime;
        Vector2 movementF = movementV + movementH;
        Vector2 straightVector = new Vector2(0f, 1f);
        float angle = Vector2.Angle(movementF, straightVector);
        m_Rigidbody.MovePosition(transform.localPosition + transform.up *m_Speed* Mathf.Abs(Mathf.Sqrt((m_MovementInputVertical*m_MovementInputVertical)+(m_TurnInputHorizontal*m_TurnInputHorizontal))) * Time.deltaTime);

        if (movementH.x < 0f)
        {
            m_Rigidbody.MoveRotation(angle - m_Rigidbody.rotation);
        }
        else if (movementH.x == 0 && movementV.y < 0 || movementH.x > 0f)
        {
            m_Rigidbody.MoveRotation(360 - angle - m_Rigidbody.rotation);
        }
        else
        {
            m_Rigidbody.MoveRotation(m_Rigidbody.rotation);
        }
    }
}
