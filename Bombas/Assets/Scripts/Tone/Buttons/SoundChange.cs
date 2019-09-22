using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundChange : MonoBehaviour
{
    private int contador = 0;
    public Sprite ImageOff;
    public Sprite ImageOn;
    private Image image;

    private void Start()
    {
        image = GetComponent<Image>();
    }

    public void changeImage()
    {
        contador++;
        Debug.Log(contador);
        if(contador %2 == 0)
        {
            
            image.sprite = ImageOn;
        }
        else
        {
            image.sprite = ImageOff;
        }

    }
}
