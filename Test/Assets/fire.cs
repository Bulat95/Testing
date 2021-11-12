using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public GameObject bullet;
    Rigidbody rbBullet;
    public GameObject spawnBullet;
    float speed = 10f;
    void Start()
    {
        rbBullet = bullet.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1")) 
        {
            Instantiate(bullet, spawnBullet.transform);
            rbBullet.velocity = new Vector3(0, 0, speed);
        }
    }
}
