using UnityEngine;
public class PlayerHealth : MonoBehaviour
{
   public float startingHealth = 100f;
   float m_CurrentHealth;
   Vector3 Position
   {
       get
       {
           return transform.position;
       }
   }
   void Start ()
   {
       m_CurrentHealth = startingHealth;
   }
   public void Damage (float damage)
   {
       m_CurrentHealth -= damage;
   }
}