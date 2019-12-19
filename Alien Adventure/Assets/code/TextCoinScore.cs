using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextCoinScore : MonoBehaviour {
	public static int ScoreCoinValue=0;
	Text scoreCoin;
	// Use this for initialization
	void Start () {
		scoreCoin = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		scoreCoin.text = ": "+ScoreCoinValue;
	}
}
