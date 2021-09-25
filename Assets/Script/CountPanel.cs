﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountPanel : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject m_strikeBallImage;
    [SerializeField] GameObject m_strikeBallImage2;
    int StrikeCount = 0;
    [SerializeField] GameObject m_BallImage;
    [SerializeField] GameObject m_BallImage2;
    [SerializeField] GameObject m_BallImage3;
    int BallCount = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        StrikeBall();
        BallBall();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (this.gameObject.tag == "Strike")
        {
            ++StrikeCount;
            ++BallCount;
        }
    }
    void StrikeBall()
    {
        if (StrikeCount == 1)
        {
            m_strikeBallImage.SetActive(true);
        }
        else if (StrikeCount == 2)
        {
            m_strikeBallImage2.SetActive(true);
        }
        else if (StrikeCount == 3)
        {
            StrikeCount = 0;
            m_strikeBallImage.SetActive(false);
            m_strikeBallImage2.SetActive(false);
        }
    }
    void BallBall()
    {
        if (BallCount == 1)
        {
            m_BallImage.SetActive(true);
        }
        else if (BallCount == 2)
        {
            m_BallImage2.SetActive(true);
        }
        else if (BallCount == 3)
        {
            m_BallImage3.SetActive(true);
        }
        else if (BallCount == 4)
        {
            BallCount = 0;
            m_BallImage.SetActive(false);
            m_BallImage2.SetActive(false);
            m_BallImage3.SetActive(false);
        }
    }
}
