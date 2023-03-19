using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{    Animator animator;
    private bool jump, left, right, log;
    [SerializeField] float speed;
    Rigidbody2D rb;
    [SerializeField] GameObject RayObject;
    [SerializeField] Vector2 startPos;
    RaycastHit2D hitWall;
    [SerializeField] Text text;
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        transform.position = startPos;
        
    }
    void Update()
    {
     
            if (Input.GetKeyDown(KeyCode.Space))
                jump = true;
            if (Input.GetKeyDown(KeyCode.A))
            {
                left = true;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                right = true;
            }
        if (Input.GetKeyDown(KeyCode.L))
        {
            log = true;

        }
        if (Input.GetKeyUp(KeyCode.Space))
                jump = false;
       
        if (Input.GetKeyUp(KeyCode.A))
            {
                left = false;
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                right = false;

            }
        if (Input.GetKeyUp(KeyCode.L))
        {
            log = false;

        }
        //right click attack on for end animation
      
        
    }
    private void FixedUpdate()
    {
        hitWall = Physics2D.Raycast(RayObject.transform.position, -Vector2.up);
        Debug.DrawRay(RayObject.transform.position, -Vector2.up * hitWall.distance, Color.red);

        if (transform.position.y > 110)
        {
            text.text = "Press 'L' To See Your Recorded Entries";
            
            if(log)
            {
                SceneManager.LoadScene("Entry");
                text.text = "";

            }
        }
        float xChange = 0f;
        float yChange = 0f;
      
         if (!right && !left && !jump)
        {
            animator.SetBool("isRun", false);
            animator.SetBool("isJump", false);
        
            RayObject.transform.position = new Vector3(transform.position.x, RayObject.transform.position.y);

        }

            if (right)
        {
            animator.SetBool("isRun", true);

            GetComponent<SpriteRenderer>().flipX = false;
            GetComponent<BoxCollider2D>().offset = new Vector2(1, 0.5284345f);
            RayObject.transform.position = new Vector3(transform.position.x + .21f, RayObject.transform.position.y);
            xChange += speed;

        }
        else if (left)
        {
            animator.SetBool("isRun", true);

            GetComponent<SpriteRenderer>().flipX = true;
            GetComponent<BoxCollider2D>().offset = new Vector2(-1f, 0.5284345f);
            RayObject.transform.position = new Vector3(transform.position.x - .16f, RayObject.transform.position.y);
            xChange -= speed;
        }





        if (jump && hitWall.distance <= 0.01)
        {
            rb.AddForce(Vector3.up * 250);
            animator.SetBool("isJump", true);

        }

        GetComponent<Transform>().position += new Vector3(xChange * Time.deltaTime, yChange * Time.deltaTime, 0);
    }
}
