using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BallKinds : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] UnityEvent ballKind;
    [SerializeField] UnityEvent ballKindSlow;
    [SerializeField] UnityEvent ballKindDown;
    public Animator m_kindAnim;


    void Start()
    {
        m_kindAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            m_kindAnim.Play("BallKinds");
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            m_kindAnim.Play("BallKindSlow");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            m_kindAnim.Play("BallKindDown");
        }
    }
}
