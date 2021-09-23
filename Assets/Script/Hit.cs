using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    [SerializeField] GameObject m_HomeRun;
    [SerializeField] Transform m_muzzle;
    Animator m_anim;
    BallKinds bk;
    // Start is called before the first frame update

    void Start()
    {
        //bk = m_HomeRun.GetComponent<BallKinds>();
        //m_kindAnim = m_HomeRun.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {   
        if (collision.gameObject.tag == "End")
        {
            Destroy(collision.gameObject);
            GameObject go = Instantiate(m_HomeRun, m_muzzle.transform.position, Quaternion.identity);
            //bk.m_kindAnim.Play("HomeRun");
        }
    }
}
