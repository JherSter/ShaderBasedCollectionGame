using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodPickup : MonoBehaviour {
	[SerializeField] Material _Fat;
	private float _FatLvL = 0f;
	private float _MinFatLvl = -0.5f;
	private float _MaxFatLvl = 5f;
	void Start(){
	 _FatLvL = 0f;
	}
	void Update(){
		
		if (_FatLvL > _MinFatLvl) {
			_FatLvL -= 0.001f;
			_Fat.SetFloat ("_Fat", _FatLvL);
		}
	}
	void OnTriggerEnter(Collider other) {
		Destroy(gameObject);

		_Fat.SetFloat ("_Fat", _MaxFatLvl);

	}
}

