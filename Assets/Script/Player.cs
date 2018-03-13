using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	//Public Variables
	public float speed;
	public int jumpForce;
	public int health;
	public Transform groundCheck;

	//Private Variables
	private bool invunerable = false;
	private bool grounded = false;
	private bool jumping = false;
	private bool facingRigth = true;

	//Unity Objects
	private SpriteRenderer sprite;
	private Rigidbody2D rb2d;
	private Animator anim;



	// Use this for initialization
	void Start () {
		sprite = GetComponent<SpriteRenderer> ();
		rb2d = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Flip()
    {
        facingRigth = !facingRigth;
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }

    private void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(move * speed, rb2d.velocity.y);

        if ((move < 0f && facingRigth) || (move > 0f && !facingRigth)) {
            Flip();
        }
    }
}
