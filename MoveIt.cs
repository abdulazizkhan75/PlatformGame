using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoveIt : MonoBehaviour
{
    public Vector3 pos, direction, pOne, pTwo;
    public int speed;
    bool flag;
    void Start()
    {
        pos = transform.position;

        pOne = pos;
        pTwo = pos;

        direction = new Vector3(0.0f, 0.0f, 0.0f);
        if (gameObject.name == "DeathCube4")
        {
            speed = 5;
            direction = new Vector3(-1.0f,0.0f,0.0f);
            pTwo.x = 19.52f;
        }
        else if (gameObject.name == "DeathCube6")
        {
            speed = 5;
            direction = new Vector3(0.0f, 0.0f, 1.0f);
            pTwo.z = -28.62f;
        }
        else if (gameObject.name == "DeathCube10")
        {
            speed = 5;
            direction = new Vector3(1.0f, 0.0f, 0.0f);
            pTwo.x = -1.2f;
        }
        else if(gameObject.name == "Platform24")
        {
            speed = 5;
            direction = new Vector3(0.0f, 0.0f, 1.0f);
            pTwo.z = 6.09f;
        }

        flag = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, pOne) < .05f || Vector3.Distance(transform.position, pTwo) < .05f)
            flag = !flag;

        if (flag)
            transform.Translate((direction * speed) * Time.deltaTime);
        else if (!flag)
            transform.Translate((-1 * direction * speed) * Time.deltaTime);
    }
}
