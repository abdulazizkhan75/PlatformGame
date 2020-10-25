using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Safezone : MonoBehaviour
{
    public static bool isProtected = false;
    void OnTriggerEnter(Collider other)
    {
        isProtected = true;
    }
    void OnTriggerExit(Collider other)
    {
        isProtected = false;
    }
}
