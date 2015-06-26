using System;
using System.Collections.Generic;
using System.Linq;

namespace TheSlum.GameEngine
{
    class NewEngine : Engine
    {
        protected override void CreateCharacter(string[] inputParams)
        {
            switch (inputParams[1])
            {
                case "warrior":
                    var warrior = new Warrior(
                        inputParams[2],
                        int.Parse(inputParams[3]),
                        int.Parse(inputParams[4]),
                        200,
                        150,
                        100,
                        (Team)Enum.Parse(typeof(Team), inputParams[5], true),
                        2
                        );
                    this.characterList.Add(warrior);
                    break;
                case "mage":
                    var mage = new Mage(
                        inputParams[2],
                        int.Parse(inputParams[3]),
                        int.Parse(inputParams[4]),
                        150,
                        300,
                        50,
                        (Team)Enum.Parse(typeof(Team), inputParams[5], true),
                        5
                        );
                    this.characterList.Add(mage);
                    break;
                case "healer":
                    var healer = new Healer(
                        inputParams[2],
                        int.Parse(inputParams[3]),
                        int.Parse(inputParams[4]),
                        75,
                        50,
                        60,
                        (Team)Enum.Parse(typeof(Team), inputParams[5], true),
                        6
                        );
                    this.characterList.Add(healer);
                    break;
                default:
                    break;
            }
        }

        protected new void AddItem(string[] inputParams)
        {
            var character = GetCharacterById(inputParams[1]);
            Item item;
            switch (inputParams[2].ToLower())
            {
                case "axe":
                    item = new Axe(inputParams[3]);
                    character.AddToInventory(item);
                    break;
                case "shield":
                    item = new Shield(inputParams[3]);
                    character.AddToInventory(item);
                    break;
                case "pill":
                    item = new Pill(inputParams[3]);
                    character.AddToInventory(item);
                    break;
                case "injection":
                    item = new Injection(inputParams[3]);
                    character.AddToInventory(item);
                    break;
                default:
                    break;
            }
        }

        protected override void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0].ToLower())
            {
                case "create":
                    CreateCharacter(inputParams);
                    break;
                case "add":
                    AddItem(inputParams);
                    break;
                default:
                    base.ExecuteCommand(inputParams);
                    break;
            }
        }

    }
}
