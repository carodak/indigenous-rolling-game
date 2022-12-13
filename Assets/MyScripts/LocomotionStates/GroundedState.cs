using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedState : ILocomotionState
{
    public void Fall(ILocomotionContext context){
        context.SetState(new InAirState());
    }

    public void Jump(ILocomotionContext context){
        context.SetState(new InAirState());
    }

    public void Land(ILocomotionContext context){
    }
}
