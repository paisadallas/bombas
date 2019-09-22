using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//***** aplicamos a nuestro objeto burbuja ****///


public class BurbujaAnimation : MonoBehaviour
{
    private CircleCollider2D cc2d;
    private Animator animator;
    private AudioSource miaudio;
    bool m_Play;    
    private float relaseDealy =0.22f;
    // Start is called before the first frame update
    void Start()
    {
        cc2d = GetComponent<CircleCollider2D>();
        animator = gameObject.GetComponent<Animator>();
        miaudio = GetComponent<AudioSource>();
        m_Play = true;
    }

    // Update is called once per frame
    void Update()
    {
      //  animator.SetBool("Explotar", cc2d.isTrigger);

        if (cc2d.isTrigger && m_Play)
        {
            miaudio.Play();
            m_Play = false;
            StartCoroutine(Release());
        }
    }

    private IEnumerator Release()
    {
        yield return new WaitForSeconds(relaseDealy);
        this.gameObject.SetActive(false);
    }
}
