using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalXP : MonoBehaviour
{

	public static int CurrentXP;
	public int InternalXP;

	void Update()
	{
		InternalXP = CurrentXP;
	}
}
