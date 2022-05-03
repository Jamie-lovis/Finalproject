using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalExp : MonoBehaviour
{
    public static int CurrentExp;
    public int InternalEXP;
    void Update()
    {
        InternalEXP = CurrentExp;
    }
}
