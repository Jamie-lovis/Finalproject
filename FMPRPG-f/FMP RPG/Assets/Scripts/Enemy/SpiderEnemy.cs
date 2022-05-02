using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderEnemy : MonoBehaviour
{

	public int EnemyHealth = 10;
	public GameObject TheSpider;
	public int SpiderStatus;
	public int BaseXP = 10;
	public int CalculatedXP;
	public SpiderAI SpiderAIScript;

	void start()
    {
		SpiderAIScript = GetComponent<SpiderAI>();
    }

	void DeductPoints(int DamageAmount)
	{
		EnemyHealth -= DamageAmount;
	}

	void Update()
	{
		if (EnemyHealth <= 0)
		{
			if (SpiderStatus == 0)
			{

				StartCoroutine(DeathSpider());
			}
		}
	}

	IEnumerator DeathSpider()
	{
		SpiderAIScript.enabled = false;
		SpiderStatus = 6;
		CalculatedXP = BaseXP * GlobalLevel.CurrentLevel;
		GlobalXP.CurrentXP += CalculatedXP;
		yield return new WaitForSeconds (0.5f);
		TheSpider.GetComponent<Animation> ().Play ("die");
	}
}
