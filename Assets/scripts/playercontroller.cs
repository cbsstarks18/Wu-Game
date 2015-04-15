using UnityEngine;
using System.Collections;

public class playercontroller : MonoBehaviour {
	public float speedForce= 50f;
	public Vector2 jumpVector;
	public bool isGrounded;
	float speed;

	public Transform grounder;
	public float radiuss;
	public LayerMask ground;

	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	

		if (Input.GetKey (KeyCode.A)) {

			speed = isGrounded ? speedForce : speedForce*0.7f;
						rigidbody2D.velocity = new Vector2 (-speed, rigidbody2D.velocity.y);
						transform.localScale = new Vector3 (-1, 1, 1);
						anim.SetInteger ("AnimationState", 1);

				} else if (Input.GetKey (KeyCode.D)) {
			speed = isGrounded ? speedForce : speedForce*0.7f;
						rigidbody2D.velocity = new Vector2 (speed, rigidbody2D.velocity.y);
						transform.localScale = new Vector3 (1, 1, 1);
						anim.SetInteger ("AnimationState", 1);
				} else if(isGrounded)
				{
					rigidbody2D.velocity = new Vector2 (0, rigidbody2D.velocity.y);
			anim.SetInteger("AnimationState", 0);


				}


		isGrounded = Physics2D.OverlapCircle (grounder.transform.position, radiuss, ground);


		if (Input.GetKey (KeyCode.W) && isGrounded == true) {
						rigidbody2D.AddForce (jumpVector, ForceMode2D.Force);
						
				} 


	}

	void OnDrawGizmos()
	{
		Gizmos.color = Color.white;
		Gizmos.DrawWireSphere (grounder.transform.position, radiuss);

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "spike") {
			Debug.Log("Dead!");
			Application.LoadLevel(0);

				}
		}

}
