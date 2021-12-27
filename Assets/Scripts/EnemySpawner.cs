using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] prefabs;

	// Use this for initialization
	void Start () {

		// trigger asynchronous randomized infinite spawning of airplanes
		StartCoroutine(SpawnAirplanes());
	}

	// Update is called once per frame
	void Update () {

	}

	IEnumerator SpawnAirplanes() {
		while (true) {

			// instantiate a random airplane past the right egde of the screen, facing left
			Instantiate(prefabs[0], new Vector3(Random.Range(-6.6f, 6.6f),6.32f, 0),
				Quaternion.Euler(0f, 0f, 0f));

			// pause this coroutine for 3-10 seconds and then repeat loop
			yield return new WaitForSeconds(Random.Range(0.2f, 0.5f));
		}
	}
}
