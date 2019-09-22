using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageCchange : MonoBehaviour
{
  
    public Sprite onePoint;
    public Sprite twoPoint;
    private Image image;
 

    private void Start()
    {
        image = GetComponent<Image>();
    }

    void Update()
    {
      if(LostLevel.no % 2 == 0)
        {
           
            image.sprite = onePoint;
        }
        else
        {
            
            image.sprite = twoPoint;             
        }
    }
    
}
