using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinIDLE : GoblinFSMState
{
    public float idleTime = 5.0f;
    private float time = 0.0f;

    public override void BeginState()
    {
        base.BeginState();
    }

    public override void EndState()
    {
        base.EndState();
    }

    private void Update()
    {
        if(GameLib.DetectCharacter(_manager.Sight,_manager.PlayerCC))
        {
            _manager.SetState(GoblinState.CHASE);
            return;

        }
        time += Time.deltaTime;
        if(time > idleTime)
        {
            _manager.SetState(GoblinState.PATROL);
        }
    }
}
