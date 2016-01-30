using UnityEngine;
using System.Collections;

public class shrinker : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ParticleSystem.ShapeModule shape = this.GetComponent<ParticleSystem>().shape;
		shape.radius -= Time.deltaTime;
	}
}
