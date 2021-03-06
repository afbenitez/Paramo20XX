using UnityEngine;

public class ZombieHitCollider : MonoBehaviour
{
    [SerializeField] private bool isHump;
    private ZombieHealth health;

    private void Awake()
    {
        health = GetComponentInParent<ZombieHealth>();
    }

    private void OnParticleCollision(GameObject other)
    {
        if (other.tag.Equals(GameTags.WaterGunParticles.ToString()))
            health.HitTimer += Time.deltaTime * (isHump ? 2 : 1);
    }
}
