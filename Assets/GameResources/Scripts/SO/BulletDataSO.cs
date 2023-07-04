using UnityEngine;

[CreateAssetMenu(fileName = "NewBulletData", menuName = "Data/BulletData")]
public class BulletDataSO : ScriptableObject
{
    public Sprite BulletSprite;
    public float MaxDistance = 10;
    public float Speed = 100;
    public int Damage = 5;
}
