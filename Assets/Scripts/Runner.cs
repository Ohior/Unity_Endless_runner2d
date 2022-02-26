/**
 * @Author: Aigboje Ohiorenua
 * @Date:   2021-09-24 01:01:53
 * @Last Modified by:   Aigboje Ohiorenua
 * @Last Modified time: 2021-10-19 14:01:47
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour
{
    public AudioClip jumpingAudioClip;
    public AudioClip explodeAudioClip;
    public AudioClip crumbleAudioClip;

    GameController game_controller;
    AudioSource audioSource;
    [SerializeField] private LayerMask platform_layermask;
    private Rigidbody2D rigidbody2d;
    private Vector3 position;
    private BoxCollider2D boxcollider2d;
    CircleCollider2D circlecollider2d;
    private Animator animator;

    public float jump_height = 10;
    public string behaviour;
    public float speed = 2f;
    public float x_movement;
    public bool runner_alive;
    bool is_grounded;

    // Start is called before the first frame update
    void Start()
    {
        game_controller = GameObject.Find("GameController").GetComponent<GameController>();
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        boxcollider2d = GetComponent<BoxCollider2D>();
        circlecollider2d = GetComponent<CircleCollider2D>();
        audioSource = GetComponent<AudioSource>();
        x_movement = speed;
        runner_alive = true;
    }


    void Update()
    {
        is_grounded = isGrounded();
        if (isKeyPress() && (collidedObject() == "Kick"))
        {
            superKick();
        }
        else if (isKeyPress() && (collidedObject() == "Jump"))
        {
            jumpUp();
        }
        else if((isGrounded() && isKeyPress()) && ((collidedObject() != "Kick") && runner_alive))
        {
            jumpUp();
        }
        else if(isGrounded() && !(isKeyPress()) && (collidedObject() != "Kick"))
        {
            runFoward();
        }
        else if(!(isGrounded() && runner_alive) && collidedObject() != "Kick")
        {
            boxcollider2d.enabled = false;
            animator.SetBool("Jump", true);
        }else
        {
            boxcollider2d.enabled = true;
        }
    }

    private bool isKeyReleased()
    {
        return Input.GetKeyUp(KeyCode.Space);
    }

    private bool isKeyPress()
    {
        return (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0));
    }

    private void superKick()
    {
        rigidbody2d.velocity = new Vector2(0, jump_height/3);
        //Animate super kick
        boxcollider2d.enabled = false;
        audioSource.Stop();
        audioSource.clip = crumbleAudioClip;
        audioSource.loop = false;
        audioSource.Play();
        // boxcollider2d.enabled = true;
        behaviour = "Kick";
        animator.SetTrigger("Kick");
    }

    private void jumpUp()
    {
        //Animate jump and make jump
        boxcollider2d.enabled = false;
        audioSource.Stop();
        audioSource.clip = jumpingAudioClip;
        audioSource.loop = false;
        audioSource.Play();
        behaviour = "Jump";
        rigidbody2d.velocity = new Vector2(rigidbody2d.velocity.x, jump_height);
        animator.SetBool("Jump", true);
    }

    void runFoward()
    {
        boxcollider2d.enabled = true;
        // Animate running
        behaviour = "Run";
        animator.SetBool("Jump", false);
    }

    private bool isGrounded()
    {
        //Return true or false
        return transform.Find("GroundCheck").GetComponent<GroundCheck>().is_grounded;
        // float layerheightcheck = 0;
        // RaycastHit2D raycasthit = Physics2D.BoxCast(circlecollider2d.bounds.center, circlecollider2d.bounds.size, 0f,  Vector2.down, layerheightcheck, platform_layermask);
        // Color raycolor;
        // if(raycasthit.collider != null){
        //     raycolor = Color.green;
        //     // circlecollider2d.enabled = false;
        // }else{
        //     raycolor = Color.red;
        //     // circlecollider2d.enabled = true;
        // }
        // Debug.DrawRay(circlecollider2d.bounds.center + new Vector3(circlecollider2d.bounds.extents.x, 0), Vector2.down * (circlecollider2d.bounds.extents.y+layerheightcheck), raycolor);
        // Debug.DrawRay(circlecollider2d.bounds.center - new Vector3(circlecollider2d.bounds.extents.x, 0), Vector2.down * (circlecollider2d.bounds.extents.y+layerheightcheck), raycolor);
        // Debug.DrawRay(circlecollider2d.bounds.center - new Vector3(0, circlecollider2d.bounds.extents.x, circlecollider2d.bounds.extents.y), Vector2.right * (circlecollider2d.bounds.extents.x), raycolor);
        // Debug.DrawRay(circlecollider2d.bounds.center - new Vector3(circlecollider2d.bounds.extents.x, circlecollider2d.bounds.extents.x, circlecollider2d.bounds.extents.y), Vector2.right * (circlecollider2d.bounds.extents.x), raycolor);
        // return raycasthit.collider != null;
    }

    private string collidedObject()
    {
        // Return Collided String tag
        return transform.Find("CollisionCheck").GetComponent<CollisionCheck>().collision_tag;
    }

    private string isUpOrDown()
    { 
        if (position.y > transform.position.y)
        {
            position = transform.position;
            return "Down";
        }if (position.y < transform.position.y)
        {
            position = transform.position;
            return "Up";
        }
        position = transform.position;
        return "null";
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        // if (collidedObject() != "Kick" && (other.gameObject.CompareTag("Rock") || other.gameObject.CompareTag("Border")))
        if ((other.gameObject.CompareTag("Rock") || other.gameObject.CompareTag("Border")) && runner_alive)
        {
            audioSource.clip = explodeAudioClip;
            audioSource.Play();
            game_controller.x_speed = 0;
            speed = 0f;
            jump_height = 0;
            runner_alive = false;
            rigidbody2d.velocity = new Vector2(0,0);
            GetComponent<SpriteRenderer>().color = Color.white;
            animator.SetTrigger("Skeleton");
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        // if(collidedObject() == "kick")
        // {

        // }
    }
}
