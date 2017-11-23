using UnityEngine;

namespace Player {
	/*
	 * Credit: Board To Bits Games
	 */
	public class Jump : MonoBehaviour {
		public float JumpVelocity;

		private void Update() {
			if (Input.GetKeyDown(KeyCode.Space)) {
				GetComponent<Rigidbody2D>().velocity = Vector2.up * JumpVelocity;
			}
		}
	}
}
