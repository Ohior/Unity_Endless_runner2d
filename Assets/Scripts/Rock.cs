/**
* @Author:  Aigboje Ohiorenua
* @Date:   2021-09-24 00:38:05
* @Last Modified by:   
* @Last Modified time: 2021-11-09 15:39:08
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

public class Rock : MonoBehaviour
{
    Runner runner;
    [SerializeField] private GameObject explosion;
    [SerializeField] private GameObject rockParticle;
    void Start()
    {
        runner = GameObject.Find("Runner").GetComponent<Runner>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // if(other.gameObject.CompareTag("Player") && (runner.behaviour == "Run" || runner.behaviour == "Jump"))
        if(other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity);
            // Instantiate(rockParticle, transform.position, Quaternion.identity);
        }else if (other.gameObject.CompareTag("Border"))
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        
    }
}
