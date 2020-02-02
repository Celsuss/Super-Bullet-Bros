using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float m_speed;
    [SerializeField]
    float m_jumpForce;
    [SerializeField]
    int m_jumpLimit;
    int m_jumpCount;

    // Start is called before the first frame update
    void Start()
    {
        Assert.AreNotEqual(m_speed, 0);
        Assert.AreNotEqual(m_jumpForce, 0);
        Assert.AreNotEqual(m_jumpLimit, 0);
        ResetJumpState();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") && m_jumpCount > 0){
            Jump();        
        }
    }

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        transform.Translate (Vector3.right * (moveHorizontal * m_speed)); 
    }

    void Jump()
    {
        transform.Translate (Vector3.up * m_jumpForce);
        m_jumpCount -= 1;
    }

    void ResetJumpState()
    {
        m_jumpCount = m_jumpLimit;
    }

     //make sure u replace "floor" with your gameobject name.on which player is standing
    void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.gameObject.tag == "Floor"){
            ResetJumpState();
        }
    }

    //consider when character is jumping .. it will exit collision.
    void OnCollisionExit(Collision theCollision)
    {
        // if (theCollision.gameObject.tag == "Floor"){
        //     isgrounded = false;
        // }
    }
}
