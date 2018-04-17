using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interrup : MonoBehaviour {

    public GameObject porte;

    public void OnCollisionEnter(Collision collision)
    {
        string temp = collision.gameObject.tag;
        if (temp == "Player1" || temp == "Player2")
        {
            Destroy(porte);
            Destroy(this.gameObject);
        }
    }

}
