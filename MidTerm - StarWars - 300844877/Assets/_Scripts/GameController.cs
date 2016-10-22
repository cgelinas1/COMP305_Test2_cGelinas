using UnityEngine;
using System.Collections;
// reference to the UI namespace
using UnityEngine.UI;


public class GameController : MonoBehaviour {
    //PRIVATE INSTANCE VARIABLES
    private int _hullPoints;
    private int _scoreValue;

    [Header("UI Objects")]
    public Text HullPointLabel;
    public Text ScoreLabel;
    
    // PUBLIC INSTANCE VARIABLES
	public int enemyCount;
	public GameObject enemy;
	
    //PUBLIC PROPERTIES

        public int HullPoints
    {
        get
        {
            return this._hullPoints;
        }
        set
        {
            this.HullPoints = value;
            if (this._hullPoints <= 0)
            {

            }
            else
            {
                this.HullPointLabel.text = "Lives: " + this._hullPoints;
            }
        }
    }

    public int ScoreValue
    {
        get
        {
            return this._scoreValue;
        }

        set
        {
            this._scoreValue = value;
            this.ScoreLabel.text = "Score: " + this._scoreValue;
        }
    }



	// Use this for initialization
	void Start () {
		this._GenerateEnemies ();
        this.ScoreValue = 0;
        this.HullPoints = 5;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// generate Clouds
	private void _GenerateEnemies() {
		for (int count=0; count < this.enemyCount; count++) {
			Instantiate(enemy);
		}
	}
}
