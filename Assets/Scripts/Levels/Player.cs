/**
* @Author:  Aigboje Ohiorenua
* @Date:   2021-11-06 14:56:06
* @Last Modified by:   
* @Last Modified time: 2021-11-07 00:22:18
*
*           ____                      ,
*          /---.'.__             ____//
*               '--.\           /.---'
*          _______  \\         //
*        /.------.\  \|      .'/  ______
*       //  ___  \ \ ||/|\  //  _/_----.\__
*      |/  /.-.\  \ \:|< >|// _/.'..\   '--'
*         //   \'. | \'.|.'/ /_/ /  \\
*        //     \ \_\/" ' ~\-'.-'    \\
*       //       '-._| :H: |'-.__     \\
*      //           (/'==='\)'-._\     ||
*      ||                        \\    \|
*      ||                         \\    '
*      |/                          \\
*                                   ||
*                                   ||
*                                   \\
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float x_force;
    public float jump_force;
    public bool is_grounded;
    Rigidbody2D rigibody2d;
    GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        rigibody2d = GetComponent<Rigidbody2D>();
        camera = GameObject.Find("Camera");
    }

    // Update is called once per frame
    void Update()
    {
        is_grounded = isGrounded();
        transform.position += new Vector3(x_force*Time.deltaTime, 0, 0);
        if(transform.position.y <= 0){
            camera.transform.position = new Vector3(camera.transform.position.x, 0f, camera.transform.position.z);
        }
        if(isKeyPress()){
            jumpUp();
        }
    }

    bool isKeyPress(){
        return Input.GetKeyDown(KeyCode.Space);
    }

    void jumpUp(){
        rigibody2d.velocity = new Vector3(rigibody2d.velocity.x, jump_force, 0);
        // rigibody2d.AddForce(Vector2.up * jump_force, ForceMode2D.Impulse);
        // rigibody2d.AddForce(Vector2.up * jump_force, ForceMode2D.Impulse);
    }

    bool isGrounded(){
        return transform.Find("IsGrounded").GetComponent<IsGrounded>().is_grounded;
    }
}
