﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallH : MonoBehaviour
{
    [SerializeField] GameObject ballPos;
    [SerializeField] GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Instantiate(ball, ballPos.transform.position, Quaternion.identity);
        }
    }
}
