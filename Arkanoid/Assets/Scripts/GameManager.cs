using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	private static GameManager _instance;

	public static GameManager Instance
	{
		get
		{
			return _instance;
		}
	}

	#region Serialized Fields
	[SerializeField] private Text _scoreText;
	#endregion

	#region Private Variables
	private int score = 0;
	#endregion

	#region Public Methods
	public void Restart()
	{
		SceneManager.LoadScene("Game");
	}

	public void ScoreUp()
	{

	}
	#endregion

	private void Awake()
	{
		if(_instance == null || _instance == this)
		{
			Destroy(this.gameObject);
		}

		_instance = this;
		DontDestroyOnLoad(this.gameObject);
	}

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		
	}
}
