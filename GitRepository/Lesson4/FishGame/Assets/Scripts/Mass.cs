using UnityEngine;
public class Mass : MonoBehaviour
{

    public float Value = 1f;

    public void ChangeValue(float amount)
    {
        Value += amount;
        if (Value < 0)
        {
            Death();
        }
    }

    public void ChangeSize(float mass)
    {
        transform.localScale += Vector3.one * mass;
    }

    public float GetValue()
    {
        return this.Value;
    }

    public void Death()
    {        
        Destroy(gameObject);
    }

    public void ValueMessage()
    {        
        Debug.Log("Ваша масса после обеда:" + this.Value);
    }

}
