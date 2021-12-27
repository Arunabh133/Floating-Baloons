using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{ 
    public float speed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       speed += 0.0001f;
       if (transform.position.y < -6.23f) {
			Destroy(gameObject);
                        MouseControl.score += 1;
		}
	else {

			// make it go twice as fast as the skyscraper spawner speed toward the left
			transform.Translate(0,-speed * 2 * Time.deltaTime, 0, Space.World);
	} 
    }

}
