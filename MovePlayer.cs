using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePlayer : MonoBehaviour
{
    bool onFloor;
    Vector3 respawnpoint;
    Vector3 jump, right, left;
    float force = 2.6f;
    Rigidbody rig;
    public static bool alive = true;

    void Start()
    {
        respawnpoint = transform.position;
        rig = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, force, 0.0f);
        right = new Vector3(0.0f, 90.0f, 0.0f);
        left = new Vector3(0.0f, -90.0f, 0.0f);
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Floor")
        {
            onFloor = true;
        }
        if(other.gameObject.tag == "Death")
        {
            transform.position = respawnpoint;
        }
    }
       
    void OnCollisionExit(Collision other)
    {
        if(other.gameObject.tag == "Floor")
        {
            onFloor = false;
        }
    }

    void Update()
    {
        if (Input.GetKey("s"))
        {
            transform.position -= transform.TransformDirection(Vector3.forward * 7) * Time.deltaTime;
        }
        else if (Input.GetKey("w") && !Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += transform.TransformDirection(Vector3.forward * 7) * Time.deltaTime;
        }
        if (!Deathzone.alive)
        {
            transform.position = respawnpoint;
            Deathzone.alive = true;
        }

        else if (Input.GetKey("d") && !Input.GetKey("a"))
        {
            transform.Rotate(right * Time.deltaTime);
        }
        else if (Input.GetKey("a") && !Input.GetKey("d"))
        {
            transform.Rotate(left * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space) && onFloor)
        {
            rig.AddForce(jump * force, ForceMode.Impulse);
        }
    }
}