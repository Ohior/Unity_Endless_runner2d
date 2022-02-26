/**
* @Author:  Aigboje Ohiorenua
* @Date:   2021-11-06 15:57:15
* @Last Modified by:   
* @Last Modified time: 2021-11-06 16:34:28
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

public class LoopingGround : MonoBehaviour
{
    public float ground_speed;
    public Renderer ground_renderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ground_renderer.material.mainTextureOffset += new Vector2(ground_speed*Time.deltaTime, 0f);
    }
}
