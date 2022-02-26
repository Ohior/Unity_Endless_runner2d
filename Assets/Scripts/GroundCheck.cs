/**
* @Author:  Aigboje Ohiorenua
* @Date:   2021-09-24 01:01:03
* @Last Modified by:   
* @Last Modified time: 2021-11-07 00:19:54
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

public class GroundCheck : MonoBehaviour
{
    [SerializeField] private LayerMask platform_layermask;
    public bool is_grounded = false;

    private void OnTriggerStay2D(Collider2D collider)
    {
        is_grounded = collider != null && (((1 << collider.gameObject.layer) & platform_layermask) != 0);
        // is_grounded = collider != null;
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        is_grounded = false;
    }
}
