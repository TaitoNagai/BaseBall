using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallH : MonoBehaviour
{
    [SerializeField] GameObject ballPos;
    [SerializeField] GameObject ball;
    float m_PitchTimer = 5f;
    float count = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        if (m_PitchTimer < count)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Instantiate(ball, ballPos.transform.position, Quaternion.identity);
                count = 0f;
            }
        }
    }
}
