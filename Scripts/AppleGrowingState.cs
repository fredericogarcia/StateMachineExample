using UnityEngine;

public class AppleGrowingState : BaseState
{
    private Vector3 startingAppleSize = new Vector3(0.1f, 0.1f, 0.1f);
    Vector3 growAppleScale = new Vector3(0.1f, 0.1f, 0.1f);
    
    public override void EnterState(StateManager state)
    {
        state.transform.localScale = startingAppleSize;
    }

    public override void UpdateState(StateManager state)
    {
        if (state.transform.localScale.x < 1)
        {
            state.transform.localScale += growAppleScale * Time.deltaTime;
        }
        else
        {
            state.SwitchState(state.WholeState);
        }
    }

    public override void OnCollisionEnter(StateManager state, Collision collision)
    {
        
    }
}
