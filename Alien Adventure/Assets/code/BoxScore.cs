using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScore : MonoBehaviour {

	private void OnCollisionEnter2D(Collision2D other)
    {
		TextScore.ScoreValue += 1;
		Destroy(gameObject);
    }
}
