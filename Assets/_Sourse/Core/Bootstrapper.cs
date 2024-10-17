using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScoreSystem;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private InputListener inputListener;
        [SerializeField] private ClickeableItemPlus clickeableItemPlus;
        private Game _game;
        private Score _score;

        void Awake()
        {
            _score = new Score(); 
            
            _game = new Game(_score);
            
            inputListener.Construct(_game);
            
            _game.StartGame();

            ClickeableItem clickableItem = FindObjectOfType<ClickeableItem>();
            if (clickableItem != null)
            {
                clickableItem.Construct(_score);
            }
            clickeableItemPlus.Construct(_score);
        }
    }
}
