using System;
using UnityEngine;

namespace BaseClasses
{
    public class HealthManager : Object
    {
        //Actual health
        [SerializeField] private float health;

        [SerializeField] private float deadlyDamage = 100f;

        public Action OnDie;

        public Action<float> OnHeal;

        //Events
        public Action<float> OnTakeDamage;

        public bool IsDead { get; private set; }


        protected override void Initialize()
        {
            base.Initialize();

            // Set health to max health
            health = deadlyDamage;
        }


        public virtual void TakeDamage(float damage, string reason)
        {
            if (IsDead) return;

            // Decrease health
            health -= damage;

            OnTakeDamage?.Invoke(damage);

            if (health <= 0)
            {
                OnDie?.Invoke();
                Die(reason);

                IsDead = true;
            }
        }

        public virtual void Heal(float heal)
        {
            // Increase health
            health += heal;

            // Clamp health
            health = Mathf.Clamp(health, 0, deadlyDamage);

            OnHeal?.Invoke(heal);
        }

        protected virtual void Die(string reason)
        {
        }

        protected override void Destroyed()
        {
            base.Destroyed();

            // Unsubscribe from OnTakeDamage
            OnTakeDamage = null;
        }

        //Get Health
        public float GetHealth()
        {
            return health;
        }

        //Get Percentage of health
        public float GetHealthPercentage()
        {
            return health / deadlyDamage;
        }
    }
}