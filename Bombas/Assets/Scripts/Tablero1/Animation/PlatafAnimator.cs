using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//**** aplicamos a nuestra plataforma ****///
public class PlatafAnimator : MonoBehaviour
{
    private PolygonCollider2D pc2d;
    private Animator animator;
    private AudioSource miaudio;
    bool m_Play;

    public AudioClip impact;

    void Start()
    {
        pc2d = GetComponent<PolygonCollider2D>();
        animator = gameObject.GetComponent<Animator>();
        miaudio = GetComponent<AudioSource>();
        m_Play = true;
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("boof", pc2d.isTrigger);
        if (pc2d.isTrigger && m_Play)
        {
            miaudio.Play();
            m_Play = false;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        miaudio.PlayOneShot(impact, 0.2f);
    }
}
