using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillanRunner : MonoBehaviour
{
    public float speed_force;
    public float jump_power;
    Rigidbody2D rigidbody2d;
    GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        camera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed_force*Time.deltaTime, 0, 0);
        if(transform.position.y <= 0){
            camera.transform.position = new Vector3(transform.position.x, 0, camera.transform.position.z);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("accending_floor")){
            rigidbody2d.velocity = new Vector3(0, 9, 0);
            speed_force = speed_force * 2;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        speed_force = speed_force / 2;
    }
}
