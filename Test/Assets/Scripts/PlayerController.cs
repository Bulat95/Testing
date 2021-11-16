using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Скорость перемещения персонажа")]
    [SerializeField] float speed = 5f;

    [Header("Сила прыжка")]
    [SerializeField] float jumpPower = 200f;

    [Header("Прикосновение с землей")]
    public bool ground;

    public Rigidbody rb;

    private void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.localPosition += transform.forward * Time.deltaTime * speed * 2;
            }
            transform.localPosition += transform.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.localPosition += transform.forward * Time.deltaTime * -speed * 2;
            }
            transform.localPosition += transform.forward * Time.deltaTime * -speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.localPosition += transform.right * Time.deltaTime * -speed * 2;
            }
            transform.localPosition += transform.right * Time.deltaTime * -speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.localPosition += transform.right * Time.deltaTime * speed * 2;
            }
            transform.localPosition += transform.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if (ground)
            {
                rb.AddForce(transform.up * jumpPower);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            ground = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            ground = false;
        }
    }
}
