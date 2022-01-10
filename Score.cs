using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

	public Transform player;
	public Text scoreText;
	public float scoreAmount;
	public float pointIncreasedPerSecond;

	// Update is called once per frame
	void Start()
	{
		scoreAmount = 0f;
		pointIncreasedPerSecond = 1f;

	}
	void Update()
	{
		scoreText.text = (int)scoreAmount + " :Score";
		scoreAmount += pointIncreasedPerSecond * Time.deltaTime;

	}
}
