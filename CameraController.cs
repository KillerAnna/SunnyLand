using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
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
        Vector3 player_Pos = player.transform.position;
        transform.position = new Vector3(player_Pos.x, transform.position.y, transform.position.z);
    }
}
