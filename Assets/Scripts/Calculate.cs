using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculate : MonoBehaviour
{
    public Material red, blue, green, white;
    GameObject starA, starB, starC;
    int time;
    double r1, r2, r3, f1, f2, f3;
    public struct Star
    {
        public float x, y, z;
        // public float vx, vy, vz;
        public float m;
    }
    Star s1, s2, s3;
    // Start is called before the first frame update
    void Start()
    {
        init();
    }
    void init()//初始化
    {
        time = 0;

        starA = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        starA.name = "starA";
        starA.transform.position = new Vector3((float)Init.x1, (float)Init.y1, (float)Init.z1);
        starA.transform.localScale = new Vector3(5, 5, 5);
        starA.AddComponent<HighlightableObject>();
        starA.AddComponent<HighLightControlRed>();
        starA.AddComponent<TrailRenderer>();
        starA.GetComponent<TrailRenderer>().material = red;
        starA.GetComponent<Renderer>().material = red;
        starA.AddComponent<Rigidbody>();
        starA.GetComponent<Rigidbody>().mass = (float)Init.m1;
        starA.GetComponent<Rigidbody>().drag = 0;
        starA.GetComponent<Rigidbody>().angularDrag = 0;
        starA.GetComponent<Rigidbody>().useGravity = false;
        starA.GetComponent<Rigidbody>().velocity = new Vector3((float)Init.vx1, (float)Init.vy1, (float)Init.vz1);
        starA.AddComponent<ConstantForce>();
        starA.GetComponent<Transform>().parent = GameObject.Find("Stars").GetComponent<Transform>().transform;
        s1.x = (float)Init.x1; s1.y = (float)Init.y1; s1.z = (float)Init.z1;
        // s1.vx = (float)Init.vx1; s1.vy = (float)Init.vy1; s1.vz = (float)Init.vz1;
        s1.m = (float)Init.m1;

        starB = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        starB.name = "starB";
        starB.transform.position = new Vector3((float)Init.x2, (float)Init.y2, (float)Init.z2);
        starB.transform.localScale = new Vector3(5, 5, 5);
        starB.AddComponent<HighlightableObject>();
        starB.AddComponent<HighLightControlBlue>();
        starB.AddComponent<TrailRenderer>();
        starB.GetComponent<TrailRenderer>().material = blue;
        starB.GetComponent<Renderer>().material = blue;
        starB.AddComponent<Rigidbody>();
        starB.GetComponent<Rigidbody>().mass = (float)Init.m2;
        starB.GetComponent<Rigidbody>().drag = 0;
        starB.GetComponent<Rigidbody>().angularDrag = 0;
        starB.GetComponent<Rigidbody>().useGravity = false;
        starB.GetComponent<Rigidbody>().velocity = new Vector3((float)Init.vx2, (float)Init.vy2, (float)Init.vz2);
        starB.AddComponent<ConstantForce>();
        starB.GetComponent<Transform>().parent = GameObject.Find("Stars").GetComponent<Transform>().transform;
        s2.x = (float)Init.x2; s2.y = (float)Init.y2; s2.z = (float)Init.z2;
        // s2.vx = (float)Init.vx2; s2.vy = (float)Init.vy2; s2.vz = (float)Init.vz2;
        s2.m = (float)Init.m2;

        starC = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        starC.name = "starC";
        starC.transform.position = new Vector3((float)Init.x3, (float)Init.y3, (float)Init.z3);
        starC.transform.localScale = new Vector3(5, 5, 5);
        starC.AddComponent<HighlightableObject>();
        starC.AddComponent<HighLightControlGreen>();
        starC.AddComponent<TrailRenderer>();
        starC.GetComponent<TrailRenderer>().material = green;
        starC.GetComponent<Renderer>().material = green;
        starC.AddComponent<Rigidbody>();
        starC.GetComponent<Rigidbody>().mass = (float)Init.m3;
        starC.GetComponent<Rigidbody>().drag = 0;
        starC.GetComponent<Rigidbody>().angularDrag = 0;
        starC.GetComponent<Rigidbody>().useGravity = false;
        starC.GetComponent<Rigidbody>().velocity = new Vector3((float)Init.vx3, (float)Init.vy3, (float)Init.vz3);
        starC.AddComponent<ConstantForce>();
        starC.GetComponent<Transform>().parent = GameObject.Find("Stars").GetComponent<Transform>().transform;
        s3.x = (float)Init.x3; s3.y = (float)Init.y3; s3.z = (float)Init.z3;
        // s3.vx = (float)Init.vx3; s3.vy = (float)Init.vy3; s3.vz = (float)Init.vz3;
        s3.m = (float)Init.m3;
    }
    // Update is called once per frame
    void Update()
    {
        time += 1;

        //读取数据
        s1.x = starA.GetComponent<Transform>().position.x; s1.y = starA.GetComponent<Transform>().position.y; s1.z = starA.GetComponent<Transform>().position.z;
        // s1.vx = starA.GetComponent<Rigidbody>().velocity.x; s1.vy = starA.GetComponent<Rigidbody>().velocity.y; s1.vz = starA.GetComponent<Rigidbody>().velocity.z;
        s1.m = starA.GetComponent<Rigidbody>().mass;
        s2.x = starB.GetComponent<Transform>().position.x; s2.y = starB.GetComponent<Transform>().position.y; s2.z = starB.GetComponent<Transform>().position.z;
        // s2.vx = starB.GetComponent<Rigidbody>().velocity.x; s2.vy = starB.GetComponent<Rigidbody>().velocity.y; s2.vz = starB.GetComponent<Rigidbody>().velocity.z;
        s2.m = starB.GetComponent<Rigidbody>().mass;
        s3.x = starC.GetComponent<Transform>().position.x; s3.y = starC.GetComponent<Transform>().position.y; s3.z = starC.GetComponent<Transform>().position.z;
        // s3.vx = starC.GetComponent<Rigidbody>().velocity.x; s3.vy = starC.GetComponent<Rigidbody>().velocity.y; s3.vz = starC.GetComponent<Rigidbody>().velocity.z;
        s3.m = starC.GetComponent<Rigidbody>().mass;

        //距离计算
        r1 = Math.Sqrt((s1.x - s2.x) * (s1.x - s2.x) + (s1.y - s2.y) * (s1.y - s2.y) + (s1.z - s2.z) * (s1.z - s2.z));//1,2
        r2 = Math.Sqrt((s3.x - s2.x) * (s3.x - s2.x) + (s3.y - s2.y) * (s3.y - s2.y) + (s3.z - s2.z) * (s3.z - s2.z));//2,3
        r3 = Math.Sqrt((s1.x - s3.x) * (s1.x - s3.x) + (s1.y - s3.y) * (s1.y - s3.y) + (s1.z - s3.z) * (s1.z - s3.z));//3,1

        //引力公式：F=G*M*m/R
        f1 = Init.g * s1.m * s2.m / r1;
        f2 = Init.g * s3.m * s2.m / r2;
        f3 = Init.g * s1.m * s3.m / r3;

        //计算每个星体在x,y,z方向上受到的引力并回写，力的空间正交分解
        starA.GetComponent<ConstantForce>().force = new Vector3((float)(f1 / r1 * (s2.x - s1.x) + f3 / r3 * (s3.x - s1.x)),
            (float)(f1 / r1 * (s2.y - s1.y) + f3 / r3 * (s3.y - s1.y)), (float)(f1 / r1 * (s2.z - s1.z) + f3 / r3 * (s3.z - s1.z)));
        starB.GetComponent<ConstantForce>().force = new Vector3((float)(f1 / r1 * (s1.x - s2.x) + f2 / r2 * (s3.x - s2.x)),
            (float)(f1 / r1 * (s1.y - s2.y) + f2 / r2 * (s3.y - s2.y)), (float)(f1 / r1 * (s1.z - s2.z) + f2 / r2 * (s3.z - s2.z)));
        starC.GetComponent<ConstantForce>().force = new Vector3((float)(f2 / r2 * (s2.x - s3.x) + f3 / r3 * (s1.x - s3.x)),
            (float)(f2 / r2 * (s2.y - s3.y) + f3 / r3 * (s1.y - s3.y)), (float)(f2 / r2 * (s2.z - s3.z) + f3 / r3 * (s1.z - s3.z)));
    }
}
