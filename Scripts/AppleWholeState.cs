using UnityEngine;

public class AppleWholeState : BaseState
{
    private float rottenCoundown = 10.0f;
    public override void EnterState(StateManager state)
    {
        state.GetComponent<Rigidbody>().useGravity = true;
    }

    public override void UpdateState(StateManager state)
    {
        if (rottenCoundown >= 0) rottenCoundown -= Time.deltaTime;
        else state.SwitchState(state.RottenState);
    }

    public override void OnCollisionEnter(StateManager state, Collision collision)
    {
        GameObject other = collision.gameObject;
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerController>().UpdateHealth(+10f);
            state.SwitchState(state.ChewedState);
        }
    }
}
