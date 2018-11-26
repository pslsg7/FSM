using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinStat : CharacterStat
{
    public StatData playerStat;
    private void Awake()
    {
        float hp = playerStat.goblinHp;
    }
}
