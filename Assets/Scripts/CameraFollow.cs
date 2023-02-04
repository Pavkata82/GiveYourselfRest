using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    private Transform player;

    private Vector3 tempPos;

    private float minX, maxX;
    // Start is called before the first frame update
    void Start()
    {
        minX = -62f;
        maxX = 62f;
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!player)
            return;

        tempPos = gameObject.transform.position;
        tempPos.x = player.transform.position.x;

        if (tempPos.x > minX && tempPos.x < maxX)
        {        
            gameObject.transform.position = tempPos;
        }
    }
}
