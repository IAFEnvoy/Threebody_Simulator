using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityControl : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(!Calculate.run) return;
        GameObject.Find("Gravity").GetComponent<Transform>().position 
            = (GameObject.Find("Stars/starA").GetComponent<Transform>().position 
            + GameObject.Find("Stars/starB").GetComponent<Transform>().position 
            + GameObject.Find("Stars/starC").GetComponent<Transform>().position) / 3;
    }
}
