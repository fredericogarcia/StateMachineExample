using UnityEngine;

public class AppleChewedState : BaseState
{
    private float destroyCountdown = 5f;
    public override void EnterState(StateManager state)
    {
    }

    public override void UpdateState(StateManager state)
    {
        if (destroyCountdown > 0) destroyCountdown -= Time.deltaTime;
        else Object.Destroy(state.gameObject);
    }

    public override void OnCollisionEnter(StateManager state, Collision collision)
    {
    }
}
