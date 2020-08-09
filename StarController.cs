using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 p1 = player.transform.position;
        Vector2 p2 = transform.position;
        Vector2 dir = p2 - p1;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 0.5f;

        if (d < r1 + r2)
        {
            Destroy(gameObject);

            GameObject manager = GameObject.Find("house");
            manager.GetComponent<GameManager>().Count();
        }
    }
}
