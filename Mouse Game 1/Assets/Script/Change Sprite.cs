using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    //variables for the game
    public SpriteRenderer sp;
    public Sprite One;
    public Sprite Two;
    public Sprite Three;


    // Start is called before the first frame update
    void Start()
    {
        sp = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && One)
        {
            sp.sprite = Two;
        }
        if (Input.GetMouseButtonUp(0) && Two)
        {
            sp.sprite = Three;
        }
    }
}
