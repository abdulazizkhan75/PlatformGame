using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathzone : MonoBehaviour
{
    public static bool alive = true;
    void OnTriggerEnter(Collider other)
    {
        if (!Safezone.isProtected && other.tag == "Player")
        {
            alive = false;
        }
    }
}
