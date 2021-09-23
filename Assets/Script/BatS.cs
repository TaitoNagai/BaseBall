using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BatS : MonoBehaviour
{
    float m_BatTimer = 4f;
    float count = 4f;
    Animator m_anim;
    // Start is called before the first frame update
    void Start()
    {
        m_anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        if(m_BatTimer < count)
        {
            if (Input.GetButtonDown("Jump"))
            {
                m_anim.Play("Swing");
                count = 0f;
            }
        } 
    }
}
