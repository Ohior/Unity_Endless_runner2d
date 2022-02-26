/**
* @Author:  Aigboje Ohiorenua
* @Date:   2021-09-23 14:29:19
* @Last Modified by:   
* @Last Modified time: 2021-11-26 11:16:43
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

public class JumpSign : MonoBehaviour
{
    private float y_speed = 2f;
    private float x_speed = -0.5f;
    int random_number;

    private void Start()
    {
        random_number = randomNumber();
        if(random_number == 0)
        {
            y_speed = 1.5f;
        }else
        {
            y_speed = -1.5f;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveJumpSign();
    }

    private void moveJumpSign()
    {
            // transform.position += new Vector3(x_speed*Time.deltaTime, y_speed*Time.deltaTime,0);
        transform.position += new Vector3(x_speed*Time.deltaTime, y_speed*Time.deltaTime,0);
        if(transform.position.y > 6 || transform.position.y < -6)
        {
            y_speed = -y_speed;
        }
    }

    private int randomNumber()
    {
        int num = Random.Range(0,2);
        return num;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Border"))
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        
    }
}
