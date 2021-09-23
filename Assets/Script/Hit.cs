using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    [SerializeField] GameObject m_ballPrefab;
    [SerializeField] Transform m_muzzle;
    Animator m_anim;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        BallKinds bk = m_ballPrefab.GetComponent<BallKinds>();
        bk.m_kindAnim = m_ballPrefab.GetComponent<Animator>();
        if (collision.gameObject.tag == "End")
        {
        Destroy(collision.gameObject);
            Debug.Log("Destroy");
            GameObject go = Instantiate(m_ballPrefab, m_muzzle.transform.position, m_ballPrefab.transform.rotation);
            bk.m_kindAnim.Play("HomeRun");
        }
    }
}
