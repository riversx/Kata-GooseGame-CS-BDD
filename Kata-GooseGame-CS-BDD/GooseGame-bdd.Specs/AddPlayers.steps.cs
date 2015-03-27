using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace GooseGame_bdd.Specs
{

    [Binding]
    public class AddPlayers
    {

        GooseGame game;

        [Given(@"There are no player in the group")]
        public void GivenThereAreNoPlayerInTheGroup()
        {
            game = new GooseGame();
        }

        [Given(@"The player ""(.*)"" is already in the group")]
        public void GivenThePlayerIsAlreadyInTheGroup(string player)
        {
            game = new GooseGame();
            game.AddPlayer(player);
        }

        [When(@"Player ""(.*)"" request to join the group")]
        public void WhenPlayerRequestToJoinTheGroup(string player)
        {
            game.AddPlayer(player);
        }

        [When(@"Another player ""(.*)"" request to join the group")]
        public void WhenAnotherPlayerRequestToJoinTheGroup(string secondPlayer)
        {
            game.AddPlayer(secondPlayer);
        }

        [Then(@"On the screen will be printed the message ""(.*)""")]
        public void ThenOnTheScreenWillBePrintedTheMessage(string expectedMessage)
        {
            Assert.AreEqual(expectedMessage, game.LastMessage);
        }

    }

}
