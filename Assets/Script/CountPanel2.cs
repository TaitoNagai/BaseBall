using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountPanel2 : MonoBehaviour
{
    [SerializeField] GameObject m_BallImage;
    [SerializeField] GameObject m_BallImage2;
    [SerializeField] GameObject m_BallImage3;
    int BallCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BallBall();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Strike")
        {
            ++BallCount;
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
