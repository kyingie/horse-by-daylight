using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private float _maxTimeSeconds;
    [SerializeField] private GameObject _startGameUI;
    [SerializeField] private GameObject _gameOverUI;

    // Add member variables to store references to all of the UI text.

    private int _commonPoints;
    private int _uncommonPoints;
    private int _rarePoints;

    private float _timeRemaining;
    private bool _runGame;

    // ------------------------------------------------------------------------
    // You don't need to code anything in this method :)
    private void Start()
    {
        SetGameEnabled(false);
        UpdatePointsText();
    }

    // ------------------------------------------------------------------------
    private void Update()
    {
        if (_runGame)
        {
            _timeRemaining -= Time.deltaTime;
            
            // Update the game timer text.

            if (_timeRemaining <= 0)
            {
                EndGame();
            }
        }
    }

    // ------------------------------------------------------------------------
    public void StartGame()
    {
        _startGameUI.SetActive(false);
        _gameOverUI.SetActive(false);
        
        SetGameEnabled(true);

        _timeRemaining = _maxTimeSeconds;
        
        // Update the game timer text.
    }

    // ------------------------------------------------------------------------
    // You don't need to code anything in this method :)
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    // ------------------------------------------------------------------------
    private void EndGame()
    {
        SetGameEnabled(false);
        _gameOverUI.SetActive(true);

        // Update the final score text in the game over UI.
    }

    // ------------------------------------------------------------------------
    // You don't need to code anything in this method :)
    private void SetGameEnabled(bool enabled)
    {
        Cursor.lockState = enabled ? CursorLockMode.Locked : CursorLockMode.None;
        _player.enabled = enabled;
        _runGame = enabled;
    }

    // ------------------------------------------------------------------------
    // Add a paramter to this method to represent the item's rarity.
    public void CollectItem ()
    {
        // Using a SWITCH STATEMENT,
        // based on the item's rarity, update the appropriate points variable.
        

        UpdatePointsText();
    }

    // ------------------------------------------------------------------------
    public void RemoveItem ()
    {
        // Using a SWITCH STATEMENT,
        // based on the item's rarity, update the appropriate points variable.
        
        UpdatePointsText();
    }

    // ------------------------------------------------------------------------
    private void UpdatePointsText()
    {
        // Update your points text.
    }
}