using UnityEngine;

namespace Player {
	/*
	 * Credit: Board To Bits Games
	 * Link: https://www.youtube.com/watch?v=7KiK0Aqtmzc
	 */
	public class Jump : MonoBehaviour {
		[Range(0, 10)]
		public float JumpVelocity;

		private void Update() {
			if (Input.GetKeyDown(KeyCode.Space)) {
				GetComponent<Rigidbody2D>().velocity = Vector2.up * JumpVelocity;
			}
		}
	}
}
