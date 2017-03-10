﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour {

	[SerializeField] private GameObject cardBack;
	[SerializeField] private SceneController sceneController;
	private int _id;

	public int id {
		get { return _id; }
	}

	public void SetCard(int id, Sprite image) {
		_id = id;
		GetComponent<SpriteRenderer> ().sprite = image;
	}


	public void OnMouseDown() {
		if (cardBack.activeSelf) {
			cardBack.SetActive (false);
		}
	}
}
