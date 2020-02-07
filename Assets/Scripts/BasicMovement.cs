using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DylanMovement
{
    /*Dylan Boswell
     *to be placed on the player character gameobject
     *sprite and snek must be assigned manually
     *requires MovementControls.cs to function properly*/
    [RequireComponent(typeof(GameObject))]
    [RequireComponent(typeof(SpriteRenderer))]
    public class BasicMovement : MonoBehaviour
    {
        
        [Header("Assignment Settings")]
            [Tooltip("The game object representing the player character")]
                public GameObject snek;
                /*The player character*/
            [Tooltip("The sprite representing the player character")]
                public SpriteRenderer sprite;
                /*the sprite in the spriterenderer*/
        [Header("Movement Settings")]
            [Tooltip("Whether the player is sneaking or not. While sneaking, they can not move")]
                public bool sneaking;
                /*bool for when you're sneaking*/

        /* Start is called before the first frame update */
        void Start()
            {
                sneaking = false;
                /*set sneaking to false on start*/
            }

        /* Update is called once per frame */
            void Update()
                {
                    if (snek == null)
                        {
                            Debug.LogError("No snek assigned to BasicMovement");
                        }
                    if (sprite == null)
                        {
                            Debug.LogError("sprite not assigned");
                        }

                }

            public void Move(Vector2 direction)
                {
                    if (sneaking == false) /*you can't move if you're sneaking*/
                        {


                            if (direction.x < 0)
                                {
                                    transform.position = transform.position + new Vector3(-0.01f, 0, 0); /*move west if the axis is tilted left i.e. A or left arrow is pressed*/
                                    Debug.Log("left");
                                }
                            else if (direction.x > 0)
                                {
                                    transform.position = transform.position + new Vector3(0.01f, 0, 0); /*same as above to the east*/
                                    Debug.Log("right");
                                }

                            if (direction.y < 0)
                                {
                                    transform.position = transform.position + new Vector3(0, -0.01f, 0); /*same as above to the south*/
                                    Debug.Log("Up");
                                }
                            else if (direction.y > 0)
                                {
                                    transform.position = transform.position + new Vector3(0, 0.01f, 0); /*same as above to the north*/
                                    Debug.Log("Down");
                                }
                        }
                   

                }

       


            public void Sneak()
                {
                    sneaking = !sneaking; /*set sneaking to the opposite of its current state*/

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
    }

