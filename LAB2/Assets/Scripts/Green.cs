using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green : MonoBehaviour {

    public GameObject GREEN;
    public Sprite firstImage;
    public Sprite secondImage;
    public Sprite thirdImage;
    private Rigidbody2D rBody;
    private SpriteRenderer sRend;

    void Start()
    {
        // Initialization of component references
        rBody = GREEN.GetComponent<Rigidbody2D>();
        sRend = GREEN.GetComponent<SpriteRenderer>();

       
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
