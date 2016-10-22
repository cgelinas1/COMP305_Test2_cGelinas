using UnityEngine;
using System.Collections;

//COMP305 Test 1 - Christopher Gelinas - 300844877 - Last Modified By: Chris Gelinas - Date Created Oct 22 2016


public class PlayerCollider : MonoBehaviour
{

    private GameObject _gameControllerObject;
    private GameController _gameController;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("TIE Fighter"))
        {
            this._gameController.HullPoints -= 1;
        }

   

  
    }
}
