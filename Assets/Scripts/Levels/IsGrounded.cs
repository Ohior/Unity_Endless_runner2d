/**
* @Author:  Aigboje Ohiorenua
* @Date:   2021-11-06 16:43:31
* @Last Modified by:   
* @Last Modified time: 2021-11-07 00:33:21
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

public class IsGrounded : MonoBehaviour
{
    public bool is_grounded;

    private void OnTriggerStay2D(Collider2D other)
    {
        // if(other.gameObject.tag == "positive_floor" || other.gameObject.tag == "negative_floor"){
        if(other.gameObject.CompareTag("positive_floor")){
        }
        other.gameObject.GetComponent<EdgeCollider2D>().enabled = true;
        is_grounded = true; //other != null;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        other.gameObject.GetComponent<EdgeCollider2D>().enabled = false;
        is_grounded = false;
    }
}
