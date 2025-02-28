using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Renderer Renderer;
    private PlayerModel playerModel;

    public void SetHealth(int amount)
    {
        playerModel.HealthAmount = amount;
    }
}

public class PlayerModel 
{
    public int HealthAmount;
}