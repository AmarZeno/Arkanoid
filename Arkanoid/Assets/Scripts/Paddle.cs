using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
	#region Inspector Fields
	[SerializeField] private float _moveSpeed = 8.0f;
	#endregion

	#region Private Methods
	private Rigidbody2D _paddleRigidBody;
	#endregion

	#region Private Methods
	private void TouchMove()
	{
		if(Input.GetMouseButton(0))
		{
			Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			if(touchPos.x < 0)
			{
				// Move left
				_paddleRigidBody.velocity = Vector2.left * _moveSpeed;

			}
			else
			{
				// Move Right
				_paddleRigidBody.velocity = Vector2.right * _moveSpeed;
			}
		}
		else
		{
			_paddleRigidBody.velocity = Vector3.zero;
		}
	}
	#endregion

	#region Monobehavior Methods
	private void Awake()
	{
		_paddleRigidBody = GetComponent<Rigidbody2D>();
	}

	// Start is called before the first frame update
	void Start()
	{
		
	}

	private void FixedUpdate()
	{
		TouchMove();
	}

	// Update is called once per frame
	void Update()
	{
		
	}
	#endregion
}
