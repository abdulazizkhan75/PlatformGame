using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ResizeIt : MonoBehaviour
{
    bool flag;
    Vector3 scaleChangeUp, scaleChangeDown;
    // Start is called before the first frame update
    void Start()
    {
        flag = true;
        scaleChangeUp = new Vector3(1f, 1f, 1f);
        scaleChangeDown = new Vector3(-1f, -1f, -1f);

    }

    // Update is called once per frame
    void Update()
    {


        if (transform.localScale.x > 5f)
            flag = false;
        else if (transform.localScale.x < 3f)
            flag = true;

        if (flag)
            transform.localScale += scaleChangeUp * Time.deltaTime;
        else if (!flag)
            transform.localScale += scaleChangeDown * Time.deltaTime;
    }
}
