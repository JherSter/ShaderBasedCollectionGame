using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodPickup : MonoBehaviour {
	[SerializeField]
	private Material _FatMaterial;
	private float _Fatness;
	private void Start()
	{
		_FatMaterial = gameObject.GetComponent<Renderer> ().material;
		_Fatness = 0.1f;
		FatMaker ();
	}
	private void Update()
	{
		_Fatness = _Fatness - 0.0003f;
		FatMaker ();
	}
	private void OnTriggerStay(Collider other)
	{

		if (other.CompareTag("Pickup") || Input.GetKeyDown(KeyCode.E)) {
			_Fatness = _Fatness + 0.1f;
			print (_Fatness);
			FatMaker ();
			Destroy (other.gameObject);
		}
	}
	private void FatMaker()
	{
		
		_FatMaterial.SetFloat ("_Amount", _Fatness);
	}
}
