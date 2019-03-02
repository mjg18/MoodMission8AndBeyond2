using UnityEngine;
using System.Collections;

public class Hydraball : MonoBehaviour {

	public int type;
	public int thought;
	public GameObject player;

	// Use this for initialization
	void Start () {
	
		Destroy (this.gameObject,2);
		//player.CharacterOurs.health = player.CharacterOurs.health - 10;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
