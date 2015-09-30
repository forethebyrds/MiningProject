using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	float createBronzeTime = 3f;
	float spawnSilverTime = 12.0f;
	float stopSpawningTime = 6.0f;
	float timeToAct = 0.0f;

	public GameObject oreCube;

	// Use this for initialization
	void Start () {

		timeToAct += createBronzeTime;

	}
	
	// Update is called once per frame
	void Update () {
	 	
		if (Time.time >= timeToAct && Time.time < spawnSilverTime + stopSpawningTime){
			// Spawn Bronze Cube 

			GameObject myCube = (GameObject) Instantiate(oreCube,
			                                             new Vector3(Random.Range(-9f, 9f), Random.Range(-3f, 5f), 0),
			                                             Quaternion.identity);

			if (Time.time >= spawnSilverTime) {
				myCube.GetComponent<Renderer>().material.color = Color.white;
			}
			else {
				myCube.GetComponent<Renderer>().material.color = Color.red;
			}

			timeToAct += createBronzeTime;
			print ("SPAWN A CUBE!!");
			print (Time.time);
			timeToAct = 0f;
		}
	}
}
