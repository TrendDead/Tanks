using UnityEngine;

[CreateAssetMenu(fileName = "NewTowerData", menuName = "Data/TowerData")]
public class TowerDataSO : ScriptableObject
{
    public Sprite TowerSprite;
    public GameObject bulletPrefab;
    public float reloadDelay = 1;
}
