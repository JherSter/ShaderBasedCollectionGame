using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodPickup : MonoBehaviour {
	[SerializeField] Material _Fat;
	private float _FatLvL = 0f;
	void Start(){
	 _FatLvL = 0f;
	}
	void Update(){
		_FatLvL -= 0.001f;
		_Fat.SetFloat ("_Fat", _FatLvL);
	}
	void OnTriggerEnter(Collider other) {
		Destroy(gameObject);
		_FatLvL = 6f;
		_Fat.SetFloat ("_Fat", _FatLvL);

	}
}

