using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class BulletMovement : MonoBehaviour
{
    [SerializeField]
    float m_speed;

    Vector3 m_direction;

    Vector3 Direction{
        get{ return m_direction; }
        set{ m_direction = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate ()
    {
        transform.Translate (m_direction * m_speed); 
    }
}