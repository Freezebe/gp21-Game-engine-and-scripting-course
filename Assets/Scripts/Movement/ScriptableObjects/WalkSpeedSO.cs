using UnityEngine;


[CreateAssetMenu (fileName = "New Custom Walk Speed", menuName = "Our Scriptable Objects/Movement/Move Speed")]
public class WalkSpeedSO : ScriptableObject
{
    [SerializeField] private float walkSpeed = 5f;
    public float WalkSpeed => walkSpeed;
    
    [SerializeField] private float chargingWalkSpeedFactor = 0.5f;
    public float ChargingWalkSpeedFactor => chargingWalkSpeedFactor;
}
