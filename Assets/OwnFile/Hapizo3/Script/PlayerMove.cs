using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

	Rigidbody2D rb2d;
	[SerializeField] float jumpPower = 0;
    // Start is called before the first frame update
    void Start()
    {
		rb2d = GetComponent<Rigidbody2D>();
    }

	void Update()
	{
		Debug.Log( rb2d.velocity.magnitude );
	}

    // Update is called once per frame
    void FixedUpdate()
    {
		float axisHor = Input.GetAxis( "Horizontal" );
		float axisVer = Input.GetAxis( "Vertical" );

		if( ( axisHor != 0 ) || ( axisVer != 0 ) )
		{
			//Debug.Log( axisHor + "," + axisVer );
			this.gameObject.transform.position += axisHor * ( this.gameObject.transform.right * 0.1f );
		}

		if( Input.GetKeyDown( "joystick button 0" ) )
		{
			//rb2d = GetComponent<Rigidbody2D>();
			rb2d.AddForce( Vector2.up * jumpPower );
		}

		//this.gameObject.transform.position += this.gameObject.transform.right;
    }
}
