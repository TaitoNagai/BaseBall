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

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ballKind.Invoke();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ballKindSlow.Invoke();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            ballKindDown.Invoke();
        }
    }
}
