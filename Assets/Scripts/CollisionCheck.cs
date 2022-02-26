/**
 * @Author: Aigboje Ohiorenua
 * @Date:   2021-09-24 01:01:34
 * @Last Modified by:   Aigboje Ohiorenua
 * @Last Modified time: 2021-10-19 14:05:21
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    public string collision_tag = "null";

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Kick"))
        {
            collision_tag = "Kick";
        }else if(other.gameObject.CompareTag("Jump"))
        {
            collision_tag = "Jump";
        }
        if(other.gameObject == null){
            collision_tag = "null";
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        collision_tag = null;
    }
}
