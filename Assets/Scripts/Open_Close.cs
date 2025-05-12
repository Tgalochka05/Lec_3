using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Close : MonoBehaviour
{
    public GameObject vorot;
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "Sphere"){
            vorot.transform.Rotate(0, 90, 0);
        }
    }
    /*
    void OnCollisionExit(Collision collision) {
        vorot.transform.Rotate(0, 90, 0);
    }*/
}
