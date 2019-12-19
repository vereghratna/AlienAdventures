 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public int animCode;
    public Animator animator;
    
    public Vector2 jumpForce = new Vector2(0, 300);
    public float speed = 5f;
    public float speedup = 2f;
    public Rigidbody2D test;

    // Use this for initialization
    void Start()
    {
        test = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) || (Input.GetKeyDown(KeyCode.UpArrow)))
        {

            test.velocity = Vector2.zero;
            test.AddForce(jumpForce);
            animCode = 1;
            animator.SetInteger("AnimCode",animCode);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            test.velocity = new Vector2(-speed, test.velocity.y);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                test.velocity = new Vector2(-speed * speedup, test.velocity.y);
            }
            animCode = 0;
            animator.SetInteger("AnimCode",animCode);
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            test.velocity = new Vector2(speed, test.velocity.y);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                test.velocity = new Vector2(speed * speedup, test.velocity.y);
            }
            animCode = 0;
            animator.SetInteger("AnimCode",animCode);
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
    void Die()
    {
        TextScore.ScoreValue = 0;
        TextCoinScore.ScoreCoinValue = 0;
        Debug.Log("Game Over");
        SceneManager.LoadScene("StageOne");
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Water"){
            Die();
        }
        if(other.gameObject.tag == "Box"){
            
        }
    }
}
