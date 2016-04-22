using UnityEngine;
using System.Collections;

public class movimiento : MonoBehaviour {
	public float deltaMovimiento = 45f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Mover ();
	}

	void Mover()
	{
		if(Input.GetKey(KeyCode.W))
			rigidbody.MovePosition(transform.position + transform.forward * deltaMovimiento * Time.deltaTime);
			//transform.Translate(Vector3.forward * deltaMovimiento * Time.deltaTime);
		else if(Input.GetKey(KeyCode.S))
			rigidbody.MovePosition(transform.position + Vector3.back * deltaMovimiento * Time.deltaTime);
			//transform.Translate(Vector3.back * deltaMovimiento * Time.deltaTime);
		else if(Input.GetKey(KeyCode.A))
			transform.Rotate(new Vector3(0f,-5f,0f) * deltaMovimiento * Time.deltaTime);
		else if(Input.GetKey(KeyCode.D))
			transform.Rotate(new Vector3(0f,5f,0f) * deltaMovimiento * Time.deltaTime);
	}
}
