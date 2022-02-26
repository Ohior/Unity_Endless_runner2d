/**
 * @Author: Aigboje Ohiorenua
 * @Date:   2021-09-24 01:16:41
 * @Last Modified by:   Aigboje Ohiorenua
 * @Last Modified time: 2021-10-12 17:37:08
 */
 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(2*Time.deltaTime, 0, 0);
    }
}
