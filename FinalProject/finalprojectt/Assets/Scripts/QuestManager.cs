using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public static int ActiveQuestNumber;
    public int InternalQuestNumber;

    public GameObject MainMark;
    public GameObject Ojective01Mark;
    public GameObject Ojective02Mark;
    public GameObject Ojective03Mark;
    public static int SubQuestNumber;
    public int InternalSubNumber;
    public GameObject Pointer;

    private void Update()
    {
        InternalQuestNumber = ActiveQuestNumber;
        InternalSubNumber = SubQuestNumber;
        Pointer.transform.LookAt(MainMark.transform);

        if (InternalSubNumber == 0)
        {
            Pointer.SetActive(false);
        }
        else
        {
            Pointer.SetActive(true);
        }

        if (InternalSubNumber == 1)
        {
            MainMark.transform.position = Ojective01Mark.transform.position;
        }

        if (InternalSubNumber == 2)
        {
            MainMark.transform.position = Ojective02Mark.transform.position;
        }

        if (InternalSubNumber == 3)
        {
            MainMark.transform.position = Ojective03Mark.transform.position;
        }
    }
}
