using UnityEngine;

public abstract class DesignPattern : MonoBehaviour
{
    protected abstract string name { get; set; }

    protected void ShowName()
    {
        Debug.Log($"## {name} ##");
    }
}