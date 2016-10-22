using UnityEngine;
using System.Collections;

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
