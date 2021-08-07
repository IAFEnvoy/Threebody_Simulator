using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeCamera : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        this.transform.rotation = GameObject.Find("Main Camera").GetComponent<Camera>().transform.rotation;
    }
}
