using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovementForIdiots : MonoBehaviour
{
    /*Dylan Boswell*//*to be placed on the player character gameobject*//*sprite and snek must be assigned manually*/
    public GameObject snek;/*The player character*/
    public bool sneaking;/*bool for when you're sneaking*/
    public SpriteRenderer sprite;/*the sprite in the spriterenderer*//* Start is called before the first frame update */
    void Start()
    {
        sneaking = false;/*set sneaking to false on start*/
    }
    /* Update is called once per frame */
    void Update()
    {
        Move(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));/*Get the orientation of the vertical and horizontal input axes every frame*/
        if (Input.GetButtonDown("Jump")) /*activate if the spacebar is pressed*/
        {
            Debug.Log("Sneak!"); /*just a fun little message that tells you the command went through */
            Sneak(); /*run sneak */
        }
    }
    void Move(Vector2 direction)
    { if (sneaking == false) /*you can't move if you're sneaking*/{
            if (direction.x < 0)
            {
                transform.position = transform.position + new Vector3(-0.01f, 0, 0); /*move west if the axis is tilted left i.e. A or left arrow is pressed*/
            }
            else if (direction.x > 0)
            {
                transform.position = transform.position + new Vector3(0.01f, 0, 0); /*same as above to the east*/
            }
            if (direction.y < 0){transform.position = transform.position + new Vector3(0, -0.01f, 0); /*same as above to the south*/
            }
            else if (direction.y > 0){transform.position = transform.position + new Vector3(0, 0.01f, 0); /*same as above to the north*/
            }
        }
    }
    void Sneak(){sneaking = !sneaking; /*set sneaking to the opposite of its current state*/
        if (sneaking == true)
        {
            sprite.color = new Color(1f, 1f, 1f, .4f); /*become transparent when sneaking to show the player the input was successful*/
        }
        else if (sneaking == false)
        {
            sprite.color = new Color(1f, 1f, 1f, 1f); /*become opaque when not sneaking to show the player the input was successful*/
        }
    }
}