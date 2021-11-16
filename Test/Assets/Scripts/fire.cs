using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public GameObject bullet;
    Rigidbody rbBullet;
    public GameObject spawnBullet;
    float speed = 100f;
    void Start()
    {
        rbBullet = bullet.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetMouseButton(0)) 
        {
            Instantiate(bullet, spawnBullet.transform);
            rbBullet.velocity = new Vector3(0, 0, Time.deltaTime);

            //rbBullet.AddForce(transform.localScale * speed * Time.deltaTime);
        }
    }
}
