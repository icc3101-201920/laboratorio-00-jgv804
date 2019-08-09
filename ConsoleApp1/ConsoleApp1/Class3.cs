using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Player
    {
        private int LifePoints;
        private int AttackPoints;
        private Deck Deck;
        private Hand Hand;
        private Board Board;
        private SpecialCard Captain;

        public int getLifePoints()
        {
            return LifePoints;
        }
        public void setLife(int lifepoints)
        {
            LifePoints = lifepoints;
        }
        public int getAttackPoints()
        {
            return AttackPoints;
        }
        public void setAttackPoints(int attackpoints)
        {
            AttackPoints = attackpoints;
        }
        public Deck getDeck()
        {
            return Deck;
        }
        public void setDeck(Deck deck)
        {
            Deck = deck;
        }
        public Hand gethand()
        {
            return Hand;
        }
        public void sethand(Hand hand)
        {
            Hand = hand;
        }
        public Board getboard()
        {
            return Board;
        }
        public void setBoard(Board board)
        {
            Board = board;

        }
        public SpecialCard getcaptain()
        {
            return Captain;
        }
        public void setcaptain(SpecialCard captain)
        {
            Captain = captain;

        }
        public void Pbuilder(int lifepoints, int attackpoints, Deck deck, Hand hand, Board board,SpecialCard captain)
        {
            this.LifePoints = lifepoints;
            this.AttackPoints = attackpoints;
            this.Deck = deck;
            this.Hand = hand;
            this.Board = board;
            this.Captain = captain;
        }

    }
}
