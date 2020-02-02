using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    BulletMovement m_bullet;

    // Start is called before the first frame update
    void Start()
    {
        Assert.IsNotNull(m_bullet);
    }

    // Update is called once per frame
    void Update()
    {
        // Fire1
    }

    void FixedUpdate ()
    {
        if(Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }

    void Shoot()
    {
        // Instantiate(m_bullet, new Vector3(0, 0, 0), Quaternion.identity);
        Vector3 mousePos = Input.mousePosition;
        // mousePos.z = 10.0;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        print(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }

    /*
        I'm finally home and lying in my bed. :D
        I had a really good time this weekend and I'm very glad that I got to meet you.
        I look forward to seeing you again and I hope it wont be too long untill we meet again.

        Maybe next time we can have Date together. ;P

        By the way how did you spell to Date in Mandarin? When I search for 'Date' I only get 日期 which I think is incorrect.
    */
}
