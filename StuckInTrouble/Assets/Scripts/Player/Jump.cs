using UnityEngine;

/*
 * Credit: Board To Bits Games
 * Link: https://www.youtube.com/watch?v=7KiK0Aqtmzc
 */
public class Jump : MonoBehaviour {
	[Range(0, 10)]
	public float JumpVelocity = 5;

	private bool _isGrounded = false;
	
	private Rigidbody2D _rigidbody2D;
	private PolygonCollider2D _polygonCollider2D;

	private void Awake() {
		_rigidbody2D = GetComponent<Rigidbody2D>();
		_polygonCollider2D = GetComponent<PolygonCollider2D>();
	}

	private void Update() {
		if (Input.GetKeyDown(KeyCode.Space) && _isGrounded) {
			_rigidbody2D.velocity = Vector2.up * JumpVelocity;
		}
	}

	private void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.CompareTag("Ground")) {
			_isGrounded = true;
		}
	}

	private void OnCollisionExit2D(Collision2D other) {
		_isGrounded = false;
	}
}
