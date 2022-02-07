using UnityEngine;

public class GameObjectToggler : MonoBehaviour
{
    public void ToggleGameObject()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
