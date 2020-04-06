using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
	[SerializeField] private Text _scoreText = null;
	[SerializeField] private GameObject _startScreen = null;
	#endregion

	#region Private Variables
	private int _score = 0;
	#endregion

	#region Public Methods
	public void Restart()
	{
		SceneManager.LoadScene("Game");
	}

	public void ScoreUp()
	{
		_score++;
		_scoreText.text = _score.ToString();
	}

	public void NotifyGameStart()
	{
		_startScreen.SetActive(false);
		_scoreText.gameObject.SetActive(true);
	}
	#endregion

	#region Monobehavior Methods
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
	#endregion
}
