using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trig : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Привет, Сфера!");
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log("Пока, Сфера!");
    }
}
