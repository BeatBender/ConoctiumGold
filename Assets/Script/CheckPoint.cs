using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

 

    public void Shine()
    {
        Debug.Log("paillettes !! vomis !!!");
        gameObject.GetComponent<Transform>().GetChild(0).gameObject.SetActive(false);
        gameObject.GetComponent<Transform>().GetChild(0).gameObject.SetActive(true);
    }
}
