using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelAnima : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private Animator animatorPanel;
    private Animator animatorPoints;
    private Animator animatorPlayer;
    public GameObject contendedor;
    public GameObject noRocas;
    public GameObject player;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animatorPanel = contendedor.GetComponent<Animator>();
        animatorPlayer = player.GetComponent<Animator>();
        animatorPoints = noRocas.GetComponent<Animator>();
        animatorPanel.SetBool("visible", true);
    }
  

    private void OnMouseDown()
    {
        animatorPanel.SetBool("visible", false);
        animatorPoints.SetBool("visible", false);
        animatorPlayer.SetBool("agachar", true);
    }

    private void OnMouseUp()
    {
        animatorPlayer.SetBool("agachar", false);
    }

    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.gameObject.tag == "Proyectiles")
        {

            animatorPanel.SetBool("visible", true);
            animatorPoints.SetBool("visible", true);
            
        }

    }
}
