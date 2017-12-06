using UnityEngine;

/*
 * Credit: Board To Bits Games
 * Link: https://www.youtube.com/watch?v=7KiK0Aqtmzc
 */
public class Jump : MonoBehaviour {
	[Range(0, 10)]
	public float JumpVelocity = 5;

	private bool _isGrounded;
	
	private Rigidbody2D _rigidbody2D;
	private Animations _animations;

	private void Awake() {
		_rigidbody2D = GetComponent<Rigidbody2D>();
		_animations = GetComponent<Animations>();
	}

	private void Update() {
		
		if (Input.GetKeyDown(KeyCode.Space) && _isGrounded) {
			_rigidbody2D.velocity = Vector2.up * JumpVelocity;
		}
	}

	private void OnCollisionEnter2D(Collision2D other) {
		if (!_isGrounded) {
			_animations.Stretch(0.05f, 0.0f);
		}
		
		if (other.gameObject.CompareTag("Ground")) {
			_isGrounded = true;
		}
	}

	private void OnCollisionExit2D(Collision2D other) {
		if (_isGrounded) {
			_animations.Squash(0.05f, 0.0f);
		}
		
		_isGrounded = false;
	}
}
