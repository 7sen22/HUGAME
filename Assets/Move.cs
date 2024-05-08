using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FPSInput : MonoBehaviour
{

    private CharacterController charcon;
    public float speed = 6f;
    public float gravity = 9.81f;
    public float jumpForce = 100f;

    private Vector3 movement;


    void Start()
    {
        movement = Vector3.zero;
        charcon = GetComponent<CharacterController>();
    }

    void Update()
    {

        Movement();
    }

    void Movement()
    {

        movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        movement *= speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            movement.y *= jumpForce;
        }
        else
        {
            movement.y -= gravity;
        }
        charcon.Move(movement * Time.deltaTime);
    }
}