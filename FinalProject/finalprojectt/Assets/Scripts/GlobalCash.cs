using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCash : MonoBehaviour
{

	public static int GoldAmount;
	public int InternalGold;
	public GameObject GoldDisplay;


	void Start()
	{

	}

	void Update()
	{
		InternalGold = GoldAmount;
		GoldDisplay.GetComponent<Text>().text = "GOLD: " + InternalGold;
	}
}
