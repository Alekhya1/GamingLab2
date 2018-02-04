using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RED : MonoBehaviour {

    public GameObject Red;
    public Sprite firstImage;
    public Sprite secondImage;
    public Sprite thirdImage;
    private Rigidbody2D rBody;
    private SpriteRenderer sRend;

    void Start()
    {
        // Initialization of component references
        rBody = Red.GetComponent<Rigidbody2D>();
        sRend = Red.GetComponent<SpriteRenderer>();

      
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
