using System;
using UnityEngine;

namespace BehavioralDesignPatterns.Command
{
    public class CommandDesignPattern : DesignPattern
    {
        protected override string name { get; set; } = "Command";
        private readonly CommandRecorder commandRecorder = new();
        [SerializeField]
        private Character character;

        private void Start()
        {
            ShowName();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                ICommand moveLeft = new MoveCommand(character, new LeftDirection());
                commandRecorder.Record(moveLeft);
            }
            
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                ICommand moveRight = new MoveCommand(character, new RightDirection());
                commandRecorder.Record(moveRight);
            }
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ICommand jump = new JumpCommand(character);
                
                commandRecorder.Record(jump);
            }
            
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                commandRecorder.Rewind();
            }
        }
    }
}