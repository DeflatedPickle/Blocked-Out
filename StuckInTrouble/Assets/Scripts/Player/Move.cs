using UnityEngine;

/*
 * Credit: Unity
 * Link: https://unity3d.com/learn/tutorials/topics/2d-game-creation/creating-basic-platformer-game
 */
public class Move : MonoBehaviour {
	public float MoveForce = 365f;
	public float MaxSpeed = 5f;

	private Rigidbody2D _rigidbody2D;

	private void Awake() {
		_rigidbody2D = GetComponent<Rigidbody2D>();
	}

	private void Update () {
		var horizontal = Input.GetAxis("Horizontal");

		if (horizontal * _rigidbody2D.velocity.x < MaxSpeed) {
			_rigidbody2D.AddForce(Vector2.right * horizontal * MoveForce);
		}

		if (Mathf.Abs(_rigidbody2D.velocity.x) > MaxSpeed) {
			_rigidbody2D.velocity = new Vector2(Mathf.Sign(_rigidbody2D.velocity.x) * MaxSpeed, _rigidbody2D.velocity.y);
		}
	}
}
