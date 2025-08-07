using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{
    public EnemyHealth enemyHealth;
    public Image healthFill; // Assign a UI Image (fill type: horizontal)

    void Update()
    {
        if (enemyHealth != null && healthFill != null)
        {
            healthFill.fillAmount = (float)enemyHealth.CurrentHealth / enemyHealth.maxHealth;
        }
    }
}