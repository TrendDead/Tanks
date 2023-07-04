using UnityEngine;

[CreateAssetMenu(fileName = "NewTankMovementData", menuName = "Data/TankMovementData")]
public class TankDataSO : ScriptableObject
{
    public float MaxSpeed = 10;
    public float RotationBodySpeed = 100;
    public float Acceleration = 70;
    public float Deacceleration = 50;

    public float TowerRotationSpeed = 150;
}
