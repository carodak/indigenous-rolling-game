using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InAirState : ILocomotionState
{
    public void Fall(ILocomotionContext context){
    }

    public void Jump(ILocomotionContext context){
    }

    public void Land(ILocomotionContext context){
        context.SetState(new GroundedState());
    }
}
