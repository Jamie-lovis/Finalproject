using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NecroWalkAI : MonoBehaviour
{

    public int Xpos;
    public int Zpos;
    public GameObject NPCDest;


    void Start()
    {
        Xpos = Random.Range(165, 190);
        Zpos = Random.Range(70, 95);
        NPCDest.transform.position = new Vector3(Xpos, 0, Zpos);
        StartCoroutine(RunRandomWalk());
    }


    void Update()
    {
        transform.LookAt(NPCDest.transform);
        transform.position = Vector3.MoveTowards(transform.position, NPCDest.transform.position, 0.02f);
    }

    IEnumerator RunRandomWalk()
    {
        yield return new WaitForSeconds(5);
        Xpos = Random.Range(165, 190);
        Zpos = Random.Range(70, 95);
        NPCDest.transform.position = new Vector3(Xpos, 0, Zpos);
        StartCoroutine(RunRandomWalk());
    }
}
