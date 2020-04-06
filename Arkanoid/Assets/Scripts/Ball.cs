using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	#region Inspector Fields
	[SerializeField] private float bounceForce = 2.0f;

	#endregion

	#region Private Variables
	private Rigidbody2D _ballRigidBody;
	private bool _ballStarted = false;
	#endregion

	#region Private Methods
	private void StartBounce()
	{
		Vector2 randomDirection = new Vector2(Random.Range(-1, 1), 1);
		_ballRigidBody.AddForce(randomDirection * bounceForce, ForceMode2D.Impulse);
	}
	#endregion

	#region Monobehavior Methods
	private void Awake()
	{
		_ballRigidBody = GetComponent<Rigidbody2D>();
		_ballRigidBody.isKinematic = true;
	}

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		if(!_ballStarted && Input.anyKeyDown)
		{
			_ballRigidBody.isKinematic = false;
			StartBounce();
			_ballStarted = true;
			GameManager.Instance.NotifyGameStart();
		}
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.tag == "Ground")
		{
			GameManager.Instance.Restart();
		}
		else if(collision.gameObject.tag == "Paddle")
		{
			GameManager.Instance.ScoreUp();
		}
	}
	#endregion
}
