using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatS : MonoBehaviour
{
    Animator m_anim;
    // Start is called before the first frame update
    void Start()
    {
        m_anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            m_anim.Play("Swing");
        }
    }
}
