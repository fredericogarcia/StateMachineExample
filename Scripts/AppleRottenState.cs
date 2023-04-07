using UnityEngine;

public class AppleRottenState : BaseState
{
    public override void EnterState(StateManager state)
    {
 
    }

    public override void UpdateState(StateManager state)
    {
        
    }

    public override void OnCollisionEnter(StateManager state, Collision collision)
    {
        GameObject other = collision.gameObject;
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerController>().UpdateHealth(-10f);
            Object.Destroy(state.gameObject);
        }
    }
}
