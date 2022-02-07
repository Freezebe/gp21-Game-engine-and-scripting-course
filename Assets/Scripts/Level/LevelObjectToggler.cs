using UnityEngine;

public class LevelObjectToggler : MonoBehaviour
{
    [SerializeField] private GameObject[] GameobjectsToToggle;

    public void ToggleObjects()
    {
        foreach (var gameObjectToToggle in GameobjectsToToggle)
        {
            gameObjectToToggle.SetActive(!gameObjectToToggle.activeSelf);
        }
    }


}
    
