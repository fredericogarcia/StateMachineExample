using System;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    private BaseState currentState;
    public AppleGrowingState GrowingState = new AppleGrowingState();
    public AppleChewedState ChewedState = new AppleChewedState();
    public AppleRottenState RottenState = new AppleRottenState();
    public AppleWholeState WholeState = new AppleWholeState();

    // called before first frame
    private void Start()
    {
        // starting the state for the state machine
        currentState = GrowingState;
        // "this" is a reference to the context (which is this exact monobehaviour script)
        currentState.EnterState(this);
    }
    // called every frame
    private void Update()
    {
        // will call any logic in the UpdateState from any state every frame
        currentState.UpdateState(this);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // calls any logic inside the OnCollisionEnter of any state that calls it
        // collision is passed through in case you need to access any logic, ie. collision.gameObject.transform
        currentState.OnCollisionEnter(this, collision);
    }

    public void SwitchState(BaseState state)
    {
        // transition to the new state passed in
        currentState = state;
        // calls EnterState logic from the state one time
        state.EnterState(this);
    }
}
