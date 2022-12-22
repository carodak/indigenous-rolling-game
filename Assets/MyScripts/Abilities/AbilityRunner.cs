using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityRunner : MonoBehaviour
{
    IAbility currentAbility = null;

    void Update(){
        if(Input.GetKeyDown("space")){
            currentAbility = GetComponent<JumpAbility>();
            UseAbility();
        }

        if(Input.GetKeyDown(KeyCode.LeftShift)){
            currentAbility = GetComponent<BoostAbility>();
            UseAbility();
        }
    }

    public void UseAbility(){
        currentAbility.Use();
    }
}
