using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinDEAD : GoblinFSMState
{
    private bool DeadCheck = false;
    [SerializeField]
    private float DeadTime = 2.0f;
    private float time = 0.0f;

    public override void BeginState()
    {      
        base.BeginState();
        time = 0.0f;
        DeadCheck = true;
    }
    public override void EndState()
    {
        base.EndState();       
    }

    private void Update()
    {
        time += Time.deltaTime;
        if(time > DeadTime)
        {
            if(DeadCheck == true)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
