using UnityEngine;

/*
 * Credit: Board To Bits Games
 * Link: https://www.youtube.com/watch?v=7KiK0Aqtmzc
 */
public class Jump : MonoBehaviour {
	[Range(0, 10)]
	public float JumpVelocity = 5;

	public bool IsGrounded;
	
	private Rigidbody2D _rigidbody2D;
	private AnimationManager _animationManager;

	private void Awake() {
		_rigidbody2D = GetComponent<Rigidbody2D>();
		_animationManager = GetComponent<AnimationManager>();
	}

	private void Update() {
		if (Input.GetKeyDown(KeyCode.Space) && IsGrounded) {
			_rigidbody2D.velocity = Vector2.up * JumpVelocity;
		}
		
		DebugInfo.AppendDebug(string.Format("Is Grounded? {0}", IsGrounded));
	}

	private void OnCollisionEnter2D(Collision2D other) {
		if (!IsGrounded) {
			_animationManager.Stretch(0.05f, 0.0f);
		}
		
		if (other.gameObject.CompareTag("Ground")) {
			IsGrounded = true;
		}
	}

	private void OnCollisionExit2D(Collision2D other) {
		if (IsGrounded) {
			_animationManager.Squash(0.05f, 0.0f);
		}
		
		IsGrounded = false;
	}
}
