using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove3D : MonoBehaviour
{

	Rigidbody rb;
	[SerializeField] float jumpPower = 0;

	// Start is called before the first frame update
	void Start()
    {
		rb = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void Update()
    {

		if( Input.GetKeyDown( "joystick button 0" ) )
		{
			//rb2d = GetComponent<Rigidbody2D>();
			rb.AddForce( Vector3.up * jumpPower );
		}
	}

	void FixedUpdate()
	{
		//スティック操作取得
		float axisHor = Input.GetAxis( "Horizontal" );
		float axisVer = Input.GetAxis( "Vertical" );

		if( ( axisHor != 0 ) || ( axisVer != 0 ) )
		{
			//Debug.Log( axisHor + "," + axisVer );
			Move( axisHor, axisVer );
		}
	}

	//プレイヤーを動かす
	void Move( float axisHor, float axisVer )
	{
		this.gameObject.transform.position += axisHor * ( this.gameObject.transform.right * 0.1f );
	}

}
