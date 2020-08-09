using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarGenerater : MonoBehaviour
{
    public GameObject star;
    GameObject go;
    GameObject go2;
    GameObject go3;
    GameObject go4;
    // Start is called before the first frame update
    void Start()
    {
        go = Instantiate(star);
        go.transform.position = new Vector2(0.2f, -0.1f);
        go2 = Instantiate(star);
        go2.transform.position = new Vector2(-0.4f, -2.6f);
        go3 = Instantiate(star);
        go3.transform.position = new Vector2(6.5f, 1f);
        go4 = Instantiate(star);
        go4.transform.position = new Vector2(9.6f, -1.7f);
    }
}
