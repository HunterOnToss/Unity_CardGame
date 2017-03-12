using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButton : MonoBehaviour {

	[SerializeField] private GameObject targetObject;
	[SerializeField] private string targetMessage;
	public Color highlightColor = Color.magenta;

	private SpriteRenderer _sprite;

	void Start() {
		_sprite = GetComponent<SpriteRenderer> ();
	}

	public void OnMouseOver() {
		if (this._sprite != null) {
			this._sprite.color = highlightColor;
		}
	}

	public void OnMouseExit() {
		if (this._sprite != null) {
			this._sprite.color = Color.white;
		}
	}

	public void OnMouseDown() {
		transform.localScale = new Vector3 (1.1f, 1.1f, 1.1f);
	}

	public void OnMouseUp() {
		transform.localScale = Vector3.one;

		if (targetObject != null) {
			targetObject.SendMessage (targetMessage);
		}
	}
}
