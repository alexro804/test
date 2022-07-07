using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class PlanetHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
    public float damage;
    public float healing;
    
    public HealthBar healthBar;
    
    // Start is called before the first frame update
    void Start()
    {
      currentHealth = maxHealth;
      damage = 1f;
      healing = 10f;
      healthBar.SetMaxHealth(maxHealth);
      StartCoroutine(DamageTime());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DamageTime()
{
  WaitForSeconds delay = new WaitForSeconds(1f);

  while(true)
  {
    currentHealth -= damage;
    healthBar.SetHealth(currentHealth);
    yield return delay;
  }
}

public void RestoreLife ()
{
 if (currentHealth <= maxHealth)
 {
  currentHealth += healing;
 } else 
 {
  return;
 }
 

}

}