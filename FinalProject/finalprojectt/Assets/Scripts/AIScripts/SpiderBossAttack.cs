using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderBossAttack : MonoBehaviour
{

    public GameObject TheEnemy;
    public int AttackTrigger;
    public int DealingDamage;

    void Update()
    {
        if (AttackTrigger == 0)
        {
            TheEnemy.GetComponent<Animation>().Play("BossWalk");
        }
        if (AttackTrigger == 1)
        {
            if (DealingDamage == 0)
            {
                TheEnemy.GetComponent<Animation>().Play("attack1");
                StartCoroutine(TakingDamage());
            }
        }
    }

    IEnumerator TakingDamage()
    {
        DealingDamage = 2;
        yield return new WaitForSeconds(0.5f);
        if (SpiderEnemy.GlobalSpider != 6)
        {
            HealthMonitor.HealthValue -= 1;
        }
        yield return new WaitForSeconds(0.4f);
        DealingDamage = 0;
    }

    void OnTriggerEnter()
    {
        AttackTrigger = 1;
    }

    void OnTriggerExit()
    {
        AttackTrigger = 0;
    }

}
