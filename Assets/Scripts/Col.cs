using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Col : MonoBehaviour
{

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "Cube"){
            Debug.Log("Столкновение!");
        }
    }

    void OnCollisionExit(Collision collision) {
        Debug.Log("Нет столкновения");
    }
}
