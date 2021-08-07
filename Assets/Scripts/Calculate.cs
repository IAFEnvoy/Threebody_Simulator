using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculate : MonoBehaviour
{
    public Material red, blue, green, white, sun, planett;
    public Font font;
    GameObject starA, starB, starC, planet;
    double time;
    double r1, r2, r3, f1, f2, f3;
    double r4, r5, r6, f4, f5, f6;
    public static bool run=true;
    public struct Star
    {
        public float x, y, z;
        public float vx, vy, vz;
        public float m;
    }
    double Temp()
    {
        double t1, t2, t3; int y1, y2, y3;
        if (s1.m > 0) y1 = 1; else y1 = 0;
        if (s2.m > 0) y2 = 1; else y2 = 0;
        if (s3.m > 0) y3 = 1; else y3 = 0;
        t1 = Math.Sqrt(Math.Sqrt(38.6 / ((s1.x - sp.x) * (s1.x - sp.x) + (s1.y - sp.y) * (s1.y - sp.y) + (s1.z - sp.z) * (s1.z - sp.z)))) * s1.m * 4;
        t2 = Math.Sqrt(Math.Sqrt(38.6 / ((s2.x - sp.x) * (s2.x - sp.x) + (s2.y - sp.y) * (s2.y - sp.y) + (s2.z - sp.z) * (s2.z - sp.z)))) * s2.m * 4;
        t3 = Math.Sqrt(Math.Sqrt(38.6 / ((s3.x - sp.x) * (s3.x - sp.x) + (s3.y - sp.y) * (s3.y - sp.y) + (s3.z - sp.z) * (s3.z - sp.z)))) * s3.m * 4;
        return (t1 * y1 + t2 * y2 + t3 * y3) / 3 - 273.15;
    }
    Star s1, s2, s3, sp;
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
        // starA.AddComponent<HighlightableObject>();
        // starA.AddComponent<HighLightControlYellow>();
        starA.AddComponent<TrailRenderer>();
        starA.GetComponent<TrailRenderer>().material = red;
        starA.GetComponent<Renderer>().material = sun;
        starA.AddComponent<Rigidbody>();
        starA.GetComponent<Rigidbody>().mass = (float)Init.m1;
        starA.GetComponent<Rigidbody>().drag = 0;
        starA.GetComponent<Rigidbody>().angularDrag = 0;
        starA.GetComponent<Rigidbody>().useGravity = false;
        starA.GetComponent<Rigidbody>().velocity = new Vector3((float)Init.vx1, (float)Init.vy1, (float)Init.vz1);
        starA.AddComponent<ConstantForce>();
        starA.AddComponent<BoomControl>();
        starA.GetComponent<Transform>().parent = GameObject.Find("Stars").GetComponent<Transform>().transform;
        s1.x = (float)Init.x1; s1.y = (float)Init.y1; s1.z = (float)Init.z1;
        s1.vx = (float)Init.vx1; s1.vy = (float)Init.vy1; s1.vz = (float)Init.vz1;
        s1.m = (float)Init.m1;
        GameObject ta = new GameObject();
        ta.AddComponent<SeeCamera>();
        ta.name = "Text";
        ta.transform.parent = starA.transform;
        ta.transform.localPosition = new Vector3(0, 0, 0);
        GameObject texta = new GameObject();
        texta.name = "_Text";
        texta.AddComponent<TextMesh>();
        texta.GetComponent<TextMesh>().text = "恒星A";
        texta.GetComponent<TextMesh>().font = font;
        texta.GetComponent<TextMesh>().fontSize = 20;
        texta.AddComponent<FontControl>();
        texta.transform.parent = ta.transform;
        texta.transform.localPosition = new Vector3(5, 0, 0);

        starB = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        starB.name = "starB";
        starB.transform.position = new Vector3((float)Init.x2, (float)Init.y2, (float)Init.z2);
        starB.transform.localScale = new Vector3(5, 5, 5);
        // starB.AddComponent<HighlightableObject>();
        // starB.AddComponent<HighLightControlYellow>();
        starB.AddComponent<TrailRenderer>();
        starB.GetComponent<TrailRenderer>().material = blue;
        starB.GetComponent<Renderer>().material = sun;
        starB.AddComponent<Rigidbody>();
        starB.GetComponent<Rigidbody>().mass = (float)Init.m2;
        starB.GetComponent<Rigidbody>().drag = 0;
        starB.GetComponent<Rigidbody>().angularDrag = 0;
        starB.GetComponent<Rigidbody>().useGravity = false;
        starB.GetComponent<Rigidbody>().velocity = new Vector3((float)Init.vx2, (float)Init.vy2, (float)Init.vz2);
        starB.AddComponent<ConstantForce>();
        starB.AddComponent<BoomControl>();
        starB.GetComponent<Transform>().parent = GameObject.Find("Stars").GetComponent<Transform>().transform;
        s2.x = (float)Init.x2; s2.y = (float)Init.y2; s2.z = (float)Init.z2;
        s2.vx = (float)Init.vx2; s2.vy = (float)Init.vy2; s2.vz = (float)Init.vz2;
        s2.m = (float)Init.m2;
        GameObject tb = new GameObject();
        tb.AddComponent<SeeCamera>();
        tb.name = "Text";
        tb.transform.parent = starB.transform;
        tb.transform.localPosition = new Vector3(0, 0, 0);
        GameObject textb = new GameObject();
        textb.name = "_Text";
        textb.AddComponent<TextMesh>();
        textb.GetComponent<TextMesh>().text = "恒星B";
        textb.GetComponent<TextMesh>().font = font;
        textb.GetComponent<TextMesh>().fontSize = 20;
        textb.AddComponent<FontControl>();
        textb.transform.parent = tb.transform;
        textb.transform.localPosition = new Vector3(5, 0, 0);

        starC = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        starC.name = "starC";
        starC.transform.position = new Vector3((float)Init.x3, (float)Init.y3, (float)Init.z3);
        starC.transform.localScale = new Vector3(5, 5, 5);
        // starC.AddComponent<HighlightableObject>();
        // starC.AddComponent<HighLightControlYellow>();
        starC.AddComponent<TrailRenderer>();
        starC.GetComponent<TrailRenderer>().material = green;
        starC.GetComponent<Renderer>().material = sun;
        starC.AddComponent<Rigidbody>();
        starC.GetComponent<Rigidbody>().mass = (float)Init.m3;
        starC.GetComponent<Rigidbody>().drag = 0;
        starC.GetComponent<Rigidbody>().angularDrag = 0;
        starC.GetComponent<Rigidbody>().useGravity = false;
        starC.GetComponent<Rigidbody>().velocity = new Vector3((float)Init.vx3, (float)Init.vy3, (float)Init.vz3);
        starC.AddComponent<ConstantForce>();
        starC.AddComponent<BoomControl>();
        starC.GetComponent<Transform>().parent = GameObject.Find("Stars").GetComponent<Transform>().transform;
        s3.x = (float)Init.x3; s3.y = (float)Init.y3; s3.z = (float)Init.z3;
        s3.vx = (float)Init.vx3; s3.vy = (float)Init.vy3; s3.vz = (float)Init.vz3;
        s3.m = (float)Init.m3;
        GameObject tc = new GameObject();
        tc.AddComponent<SeeCamera>();
        tc.name = "Text";
        tc.transform.parent = starC.transform;
        tc.transform.localPosition = new Vector3(0, 0, 0);
        GameObject textc = new GameObject();
        textc.name = "_Text";
        textc.AddComponent<TextMesh>();
        textc.GetComponent<TextMesh>().text = "恒星C";
        textc.GetComponent<TextMesh>().font = font;
        textc.GetComponent<TextMesh>().fontSize = 20;
        textc.AddComponent<FontControl>();
        textc.transform.parent = tc.transform;
        textc.transform.localPosition = new Vector3(5, 0, 0);

        if (!Init.enablep) return;

        planet = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        planet.name = "planet";
        planet.transform.position = new Vector3((float)Init.xp, (float)Init.yp, (float)Init.zp);
        planet.transform.localScale = new Vector3(1, 1, 1);
        // planet.AddComponent<HighlightableObject>();
        // planet.AddComponent<HighLightControlYellow>();
        planet.AddComponent<TrailRenderer>();
        planet.GetComponent<TrailRenderer>().material = white;
        planet.GetComponent<Renderer>().material = planett;
        planet.AddComponent<Rigidbody>();
        planet.GetComponent<Rigidbody>().mass = (float)Init.mp;
        planet.GetComponent<Rigidbody>().drag = 0;
        planet.GetComponent<Rigidbody>().angularDrag = 0;
        planet.GetComponent<Rigidbody>().useGravity = false;
        planet.GetComponent<Rigidbody>().velocity = new Vector3((float)Init.vxp, (float)Init.vyp, (float)Init.vzp);
        planet.AddComponent<ConstantForce>();
        planet.AddComponent<BoomControl>();
        planet.GetComponent<Transform>().parent = GameObject.Find("Stars").GetComponent<Transform>().transform;
        sp.x = (float)Init.xp; sp.y = (float)Init.yp; sp.z = (float)Init.zp;
        sp.vx = (float)Init.vxp; sp.vy = (float)Init.vyp; sp.vz = (float)Init.vzp;
        sp.m = (float)Init.mp;
        GameObject tp = new GameObject();
        tp.AddComponent<SeeCamera>();
        tp.name = "Text";
        tp.transform.parent = planet.transform;
        tp.transform.localPosition = new Vector3(0, 0, 0);
        GameObject textp = new GameObject();
        textp.name = "_Text";
        textp.AddComponent<TextMesh>();
        textp.GetComponent<TextMesh>().text = "行星";
        textp.GetComponent<TextMesh>().font = font;
        textp.GetComponent<TextMesh>().fontSize = 20;
        textp.AddComponent<FontControl>();
        textp.transform.parent = tp.transform;
        textp.transform.localPosition = new Vector3(5, 0, 0);

    }
    string bettershow(string in1)
    {
        string out1 = in1;
        if (out1.Contains("."))
            for (int i = in1.Split('.')[1].Length; i < 2; i++)
                out1 = out1 + "0";
        else out1 = out1 + ".00";
        for (int i = out1.Length; i <= 7; i++)
            out1 = " " + out1;
        return out1;
    }
    // Update is called once per frame
    void Update()
    {
        if (!run)
        {
            try { starA.GetComponent<ConstantForce>().force = new Vector3(0, 0, 0); } catch { }
            try { starB.GetComponent<ConstantForce>().force = new Vector3(0, 0, 0); } catch { }
            try { starC.GetComponent<ConstantForce>().force = new Vector3(0, 0, 0); } catch { }
            if (Init.enablep)
                try { planet.GetComponent<ConstantForce>().force = new Vector3(0, 0, 0); } catch { }
            return;
        }

        time += 0.1;
        GameObject.Find("Canvas/UI/Time").GetComponent<Text>().text = bettershow(Math.Round(time, 1).ToString()) + "年";

        GameObject.Find("Canvas/UI/Info").GetComponent<Text>().text
            = "摄像机距离:" + camera_move.distance.ToString() + "  FPS:" + Math.Round((1.0 / Time.deltaTime)).ToString() + "\n"
            + "<color=#FF0000>恒星A:m=" + bettershow(Math.Round(Init.m1, 1).ToString()) + " x=" + bettershow(Math.Round(s1.x, 2).ToString())
                + " y=" + bettershow(Math.Round(s1.y, 2).ToString()) + " z=" + bettershow(Math.Round(s1.z, 2).ToString())
                + " v=" + bettershow(Math.Round(Math.Sqrt(s1.vx * s1.vx + s1.vy * s1.vy + s1.vz * s1.vz), 2).ToString()) + "</color>\n"
            + "<color=#00BFFF>恒星B:m=" + bettershow(Math.Round(Init.m2, 1).ToString()) + " x=" + bettershow(Math.Round(s2.x, 2).ToString())
                + " y=" + bettershow(Math.Round(s2.y, 2).ToString()) + " z=" + bettershow(Math.Round(s2.z, 2).ToString())
                + " v=" + bettershow(Math.Round(Math.Sqrt(s2.vx * s2.vx + s2.vy * s2.vy + s2.vz * s2.vz), 2).ToString()) + "</color>\n"
            + "<color=#00FF00>恒星C:m=" + bettershow(Math.Round(Init.m3, 1).ToString()) + " x=" + bettershow(Math.Round(s3.x, 2).ToString())
                + " y=" + bettershow(Math.Round(s3.y, 2).ToString()) + " z=" + bettershow(Math.Round(s3.z, 2).ToString())
                + " v=" + bettershow(Math.Round(Math.Sqrt(s3.vx * s3.vx + s3.vy * s3.vy + s3.vz * s3.vz), 2).ToString()) + "</color>\n";
        if (Init.enablep)
        {
            double t = Temp();
            GameObject.Find("Canvas/UI/Info").GetComponent<Text>().text
            += "<color=#FFFFFF>行星 :m=" + bettershow(Math.Round(Init.mp, 1).ToString()) + " x=" + bettershow(Math.Round(sp.x, 2).ToString())
                + " y=" + bettershow(Math.Round(sp.y, 2).ToString()) + " z=" + bettershow(Math.Round(sp.z, 2).ToString())
                + " v=" + bettershow(Math.Round(Math.Sqrt(sp.vx * sp.vx + sp.vy * sp.vy + sp.vz * sp.vz), 2).ToString()) + "</color>\n"
            + (t > Init.maxtemp ? "<color=#FF0000>" : t < Init.mintemp ? "<color=#00BFFF>" : "<color=#00FF00>")
                + "行星表面温度:" + bettershow(Math.Round(t, 2).ToString()) + "℃</color>";
        }

        //读取数据
        s1.x = starA.GetComponent<Transform>().position.x; s1.y = starA.GetComponent<Transform>().position.y; s1.z = starA.GetComponent<Transform>().position.z;
        s1.vx = starA.GetComponent<Rigidbody>().velocity.x; s1.vy = starA.GetComponent<Rigidbody>().velocity.y; s1.vz = starA.GetComponent<Rigidbody>().velocity.z;
        s1.m = starA.GetComponent<Rigidbody>().mass;
        s2.x = starB.GetComponent<Transform>().position.x; s2.y = starB.GetComponent<Transform>().position.y; s2.z = starB.GetComponent<Transform>().position.z;
        s2.vx = starB.GetComponent<Rigidbody>().velocity.x; s2.vy = starB.GetComponent<Rigidbody>().velocity.y; s2.vz = starB.GetComponent<Rigidbody>().velocity.z;
        s2.m = starB.GetComponent<Rigidbody>().mass;
        s3.x = starC.GetComponent<Transform>().position.x; s3.y = starC.GetComponent<Transform>().position.y; s3.z = starC.GetComponent<Transform>().position.z;
        s3.vx = starC.GetComponent<Rigidbody>().velocity.x; s3.vy = starC.GetComponent<Rigidbody>().velocity.y; s3.vz = starC.GetComponent<Rigidbody>().velocity.z;
        s3.m = starC.GetComponent<Rigidbody>().mass;
        if (Init.enablep)
        {
            sp.x = planet.GetComponent<Transform>().position.x; sp.y = planet.GetComponent<Transform>().position.y; sp.z = planet.GetComponent<Transform>().position.z;
            sp.vx = planet.GetComponent<Rigidbody>().velocity.x; sp.vy = planet.GetComponent<Rigidbody>().velocity.y; sp.vz = planet.GetComponent<Rigidbody>().velocity.z;
            sp.m = planet.GetComponent<Rigidbody>().mass;
        }

        //距离计算
        r1 = Math.Sqrt((s1.x - s2.x) * (s1.x - s2.x) + (s1.y - s2.y) * (s1.y - s2.y) + (s1.z - s2.z) * (s1.z - s2.z));//1,2
        r2 = Math.Sqrt((s3.x - s2.x) * (s3.x - s2.x) + (s3.y - s2.y) * (s3.y - s2.y) + (s3.z - s2.z) * (s3.z - s2.z));//2,3
        r3 = Math.Sqrt((s1.x - s3.x) * (s1.x - s3.x) + (s1.y - s3.y) * (s1.y - s3.y) + (s1.z - s3.z) * (s1.z - s3.z));//3,1
        if (Init.enablep)
        {
            r4 = Math.Sqrt((s1.x - sp.x) * (s1.x - sp.x) + (s1.y - sp.y) * (s1.y - sp.y) + (s1.z - sp.z) * (s1.z - sp.z));//1
            r5 = Math.Sqrt((sp.x - s2.x) * (sp.x - s2.x) + (sp.y - s2.y) * (sp.y - s2.y) + (sp.z - s2.z) * (sp.z - s2.z));//2
            r6 = Math.Sqrt((sp.x - s3.x) * (sp.x - s3.x) + (sp.y - s3.y) * (sp.y - s3.y) + (sp.z - s3.z) * (sp.z - s3.z));//3
        }

        //引力公式：F=G*M*m/R
        f1 = Init.g * s1.m * s2.m / r1;
        f2 = Init.g * s3.m * s2.m / r2;
        f3 = Init.g * s1.m * s3.m / r3;
        if (Init.enablep)
        {
            f4 = Init.g * s1.m * sp.m / r4;
            f5 = Init.g * s2.m * sp.m / r5;
            f6 = Init.g * s3.m * sp.m / r6;
        }

        //计算每个星体在x,y,z方向上受到的引力并回写，力的空间正交分解
        starA.GetComponent<ConstantForce>().force = new Vector3((float)(f1 / r1 * (s2.x - s1.x) + f3 / r3 * (s3.x - s1.x)),
            (float)(f1 / r1 * (s2.y - s1.y) + f3 / r3 * (s3.y - s1.y)), (float)(f1 / r1 * (s2.z - s1.z) + f3 / r3 * (s3.z - s1.z)));
        starB.GetComponent<ConstantForce>().force = new Vector3((float)(f1 / r1 * (s1.x - s2.x) + f2 / r2 * (s3.x - s2.x)),
            (float)(f1 / r1 * (s1.y - s2.y) + f2 / r2 * (s3.y - s2.y)), (float)(f1 / r1 * (s1.z - s2.z) + f2 / r2 * (s3.z - s2.z)));
        starC.GetComponent<ConstantForce>().force = new Vector3((float)(f2 / r2 * (s2.x - s3.x) + f3 / r3 * (s1.x - s3.x)),
            (float)(f2 / r2 * (s2.y - s3.y) + f3 / r3 * (s1.y - s3.y)), (float)(f2 / r2 * (s2.z - s3.z) + f3 / r3 * (s1.z - s3.z)));
        if (Init.enablep)
            planet.GetComponent<ConstantForce>().force = new Vector3(
                (float)(f4 / r4 * (s1.x - sp.x) + f5 / r5 * (s2.x - sp.x) + f6 / r6 * (s3.x - sp.x)),
                (float)(f4 / r4 * (s1.y - sp.y) + f5 / r5 * (s2.x - sp.x) + f6 / r6 * (s3.y - sp.y)),
                (float)(f4 / r4 * (s1.z - sp.z) + f5 / r5 * (s2.x - sp.x) + f6 / r6 * (s3.z - sp.z)));
    }
}
