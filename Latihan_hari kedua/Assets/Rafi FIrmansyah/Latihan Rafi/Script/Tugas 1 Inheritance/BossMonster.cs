using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMonster : Monster
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InfoMonster();
        }

    }

}
