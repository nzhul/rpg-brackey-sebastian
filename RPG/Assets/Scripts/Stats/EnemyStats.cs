public class EnemyStats : CharacterStats {

    public override void Die()
    {
        base.Die();

        // add ragdoll effect / death animation

        Destroy(gameObject);
    }
}
