using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScore : MonoBehaviour {

	private void OnCollisionEnter2D(Collision2D other)
    {
		TextCoinScore.ScoreCoinValue += 1;
		Destroy(gameObject);
    }

}
