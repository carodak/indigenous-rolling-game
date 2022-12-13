using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILocomotionState {
    void Jump(ILocomotionContext context);
    void Fall(ILocomotionContext context);
    void Land(ILocomotionContext context);
}
