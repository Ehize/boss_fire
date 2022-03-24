using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickEffect : MonoBehaviour
{
    public GameEvent bossDestroyed;

    [SerializeField]
    private int healthDecreaseAmount = 10;

    [SerializeField]
    private HealthbarBehaviour healthbar;


     IEnumerator Dead() {
     Debug.Log ("dead");
     bossDestroyed.Raise();
     healthbar.DecreaseHealth(healthDecreaseAmount);

     if (healthbar.health <= 0) {
         GetComponent<Renderer>().enabled = false;
         yield return new WaitForSeconds(3);
         Debug.Log ("respawn");
         bossDestroyed.Raise();
         
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
         GetComponent<Renderer>().enabled = true;
     }
 }

 void OnMouseDown() {
    StartCoroutine (Dead());
 }

}
