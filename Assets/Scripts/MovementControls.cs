using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DylanMovement;

[RequireComponent(typeof(DylanMovement.BasicMovement))]
public class MovementControls : MonoBehaviour
{
    /*Dylan Boswell
   * To be placed on the player character gameobject
   * requires BasicMovement.cs to function properly*/
    DylanMovement.BasicMovement controller;

    public GameObject bulletRevolver;
    public SpriteRenderer bulletSprite;

    // Start is called before the first frame update
    void Start()
    {
        GameObject bullet = GameObject.Instantiate(bulletRevolver, new Vector3(1, 1, 0), Quaternion.identity);
    }

    public void Awake()
    {
        controller = GetComponent<DylanMovement.BasicMovement>();
        /*assigns controller on waking*/
    }

    // Update is called once per frame
    public void Update()
    {

        if (controller == null)
        {
            Debug.LogError("controller ain't workin my dude");
            /*error if there is no controller assigned, i.e., there is no BasicMovement.cs*/
        }


        controller.Move(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        /*Get the orientation of the vertical and horizontal input axes every frame, supplies them to Move() from BasicMovement*/

        if ((Input.GetButtonDown("Jump"))) /*activate if the spacebar is pressed*/

        {


            Debug.Log("Sneak!"); /*just a fun little message that tells you the command went through */
            controller.Sneak(); /*run sneak from BasicMovement*/


        }

        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("fire!");

        }

    }




}
