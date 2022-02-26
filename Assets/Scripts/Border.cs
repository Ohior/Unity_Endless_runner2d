/**
* @Author:  Aigboje Ohiorenua
* @Date:   2021-09-23 13:56:09
* @Last Modified by:   
* @Last Modified time: 2021-11-26 11:07:00
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

public class Border : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Runner runner = GameObject.Find("Runner").GetComponent<Runner>();
            runner.runner_alive = false;
        }else
        {
            Destroy(other.gameObject);
        }
    }
}
