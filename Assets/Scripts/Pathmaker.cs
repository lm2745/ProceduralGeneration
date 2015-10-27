using UnityEngine;
using System.Collections;

public class Pathmaker : MonoBehaviour {
	
	int counter = 0;
	public Transform floorPrefab;
	public Transform pathmakerPrefab;
	
	Transform clones;
	GameObject clone;

	int randomValue;
	Vector3 randomPosition;
	Vector3 yPositions;

	void Start () {
		randomValue = Random.Range (25, 100);
		randomPosition = new Vector3(Random.Range (-transform.position.x, transform.position.x),
		                             Random.Range (0, 5),
		                             Random.Range (-transform.position.z, transform.position.z));
	}

	void Update () {
		
		if (counter < 20) {
			
			float rand = Random.Range (0.0f, 1.0f);
			
			if (rand < 0.25f) { 
				transform.Rotate (0f, 90f, 0f);
			}
			else if (rand < 0.25f && rand < 0.5f) { 
				transform.Rotate (0f, -90f, 0f);
			}
			else if (rand > 0.97f) { 
				Instantiate (pathmakerPrefab, transform.position, transform.rotation);
			}
			
			Instantiate (floorPrefab, transform.position, transform.rotation);
			transform.Translate (0f, 0f, 5f);
			counter++;
		}
		
		else {
			Destroy (this.gameObject); 
		}
	}
}
