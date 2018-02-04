using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YELLOW : MonoBehaviour {

    public GameObject Yellow;
    public Sprite firstImage;
    public Sprite secondImage;
    public Sprite thirdImage;

    private Rigidbody2D rBody;
    private SpriteRenderer sRend;

    void Start()
    {
        // Initialization of component references
        rBody = Yellow.GetComponent<Rigidbody2D>();
        sRend = Yellow.GetComponent<SpriteRenderer>();

     
    }
    // Executes when a mouse down event occurs on an object with this script.
    void OnMouseDown()
    {
        if (sRend.sprite == firstImage)
        {
            sRend.sprite = secondImage;
        }
        else
        {
            sRend.sprite = thirdImage;
        }

        rBody.velocity *= -1;


    }
}
